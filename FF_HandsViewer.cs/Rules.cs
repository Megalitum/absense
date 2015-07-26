using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace BindSense.cs
{
	class Rules
	{
        private static Dictionary<string, string> rulesContainer = new Dictionary<string, string>();
        private const string serializationFilepath = "rules.dat";

        static Rules()
        {
            foreach(string gesture in Rules.getGesturesList())
                Rules.rulesContainer[gesture] = null;

            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream(Rules.serializationFilepath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    Rules.rulesContainer = binFormat.Deserialize(fStream) as Dictionary<string, string>;
                }
            }
            catch (System.IO.FileNotFoundException) // ok, there aren't any rules saved yet
            {
            }
        }

		public static void SetGesture(string gesture, string key) // add rule
		{
            Rules.rulesContainer[gesture] = key;
		}

        public static string get(string gesture)
        {
            return Rules.rulesContainer[gesture];
        }

		public static void Clear()
		{
            foreach (string gesture in Rules.getGesturesList())
                Rules.rulesContainer[gesture] = null;
		}

		public static IEnumerable<KeyValuePair<string, string>> Read()
		{
			Rules.Clear();
			BinaryFormatter binFormat = new BinaryFormatter();

			try
			{
				using (Stream fStream = new FileStream(Rules.serializationFilepath, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					Rules.rulesContainer = binFormat.Deserialize(fStream) as Dictionary<string, string>;
				}
			}
			catch (System.IO.FileNotFoundException) // ok, there aren't any rules saved yet
			{
			}

			foreach (KeyValuePair<string, string> rule in Rules.rulesContainer)
				yield return rule;
		}

		public static void Write()
		{
			BinaryFormatter binFormat = new BinaryFormatter();

			// try / catch ?
			using (Stream fStream = new FileStream(Rules.serializationFilepath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
			{
				binFormat.Serialize(fStream, Rules.rulesContainer);
			}
		}

		public static string[] getGesturesList()
		{
			return new string[] {
				"click",
				"fist",
                "full_pinch",
                "swipe_down",
                "swipe_up",
                "swipe_left",
                "swipe_right",
                "tap",
                "thumb_up",
                "thumb_down",
                "two_fingers_pinch_open",
                "v_sign",
                "wave"
			};
		}
	}
}