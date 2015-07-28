using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BindSense.cs
{
	[Serializable]
	class Preset : ICloneable
	{
		private Dictionary<string, string> eventsMap; // A map between "events" and corresponding key strokes

		public Dictionary<string, string> EventsMap
		{ 
			get { return this.eventsMap; } 
		}

		public Preset()
		{
			this.eventsMap = new Dictionary<string, string>();
		}

		public Preset(Dictionary<string, string> events)
		{
			this.eventsMap = events;
		}

		public void Bind(string eventName, string keyStroke)
		{
			if (this.eventsMap.ContainsKey(eventName))
				this.eventsMap[eventName] = keyStroke;
			else
				throw new KeyNotFoundException();
		}

		public void Raise(string eventName)
		{
			string keyStroke = this.eventsMap[eventName];
			if (!string.IsNullOrEmpty(keyStroke))
				SendKeys.SendWait(keyStroke);
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}

	class BindableEntity
	{
		private Dictionary<string, Preset> appsMap; // A map between app names and "presets"
		private Dictionary<string, Preset> presets; // Presets stored for this entity

		public BindableEntity(HashSet<string> events, string serializationFilepath)
		{
			this.appsMap = new Dictionary<string, Preset>();
			this.presets = new Dictionary<string, Preset>();
			this.Events = events;
			this.SerializationFilepath = serializationFilepath;
		}

		public IEnumerable<string> Events { get; private set; }
		public IEnumerable<string> Presets { get { return this.presets.Keys; } }
		public string SerializationFilepath { get; private set; }

		// Add new only if not in appsMap, return true in this case
		public void AddApp(string appName)
		{
			if (!string.IsNullOrEmpty(appName) && !this.appsMap.ContainsKey(appName))
				this.appsMap.Add(appName, new Preset(this.Events.ToDictionary(key => key, value => string.Empty)));
		}

		// Bind only if appsMap contains appName
		public void Bind(string appName, string eventName, string keyStroke)
		{
			if (this.appsMap.ContainsKey(appName))
				this.appsMap[appName].Bind(eventName, keyStroke);
		}

		// Raise only if appsMap contains active app
		public void Raise(string eventName)
		{
			string activeAppName = WinApiUtility.ActiveAppName();
			Preset activeAppPreset;
			if (this.appsMap.TryGetValue(activeAppName, out activeAppPreset))
				if (activeAppPreset != null)
					activeAppPreset.Raise(eventName);
		}

		// Get events map only if appsMap contains appName
		public IEnumerable<KeyValuePair<string, string>> EventsMap(string appName)
		{
			Preset appPreset;
			if (this.appsMap.TryGetValue(appName, out appPreset))
				return this.appsMap[appName].EventsMap.ToList();
			return Enumerable.Empty<KeyValuePair<string, string>>();
		}

		// Add or update if exists, filter only acceptable events
		public void AddPreset(string presetName, Dictionary<string, string> presetMap)
		{
			this.presets[presetName] = new Preset(presetMap
				.Where(kvp => this.Events.Contains(kvp.Key))
				.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
			);
		}

		// Get events map only if presets contains presetName
		public IEnumerable<KeyValuePair<string, string>> EventsMapPreset(string presetName)
		{
			Preset preset;
			if (this.presets.TryGetValue(presetName, out preset))
				return this.presets[presetName].EventsMap.ToList();
			return Enumerable.Empty<KeyValuePair<string, string>>();
		}

		// Set appName's preset to presetName only if both are present in dicts
		public void ApplyPreset(string appName, string presetName)
		{
			Preset preset;
			if (
				this.appsMap.ContainsKey(appName) && 
				this.presets.TryGetValue(presetName, out preset) &&
				preset != null
			)
				this.appsMap[appName] = (Preset)preset.Clone();
		}

		public void RemovePreset(string presetName)
		{
			this.presets.Remove(presetName);
		}

		public void Save()
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			// try / catch ?
			using (Stream fStream = new FileStream(this.SerializationFilepath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
			{
				binFormat.Serialize(fStream, new List<Dictionary<string, Preset>>() { this.appsMap, this.presets });
			}
		}

		public void Load()
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			try
			{
				using (Stream fStream = new FileStream(this.SerializationFilepath, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					var loadedData = binFormat.Deserialize(fStream) as List<Dictionary<string, Preset>>;
					if (loadedData != null)
					{
						this.appsMap = loadedData[0];
						this.presets = loadedData[1];
					}
				}
			}
			catch (System.IO.FileNotFoundException) // ok, there aren't any data saved yet
			{
			}
		}
	}
}