using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;
using System.Diagnostics;

namespace BindSense.cs
{
	struct WinApiUtility
	{
		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

		public static string ActiveAppName()
		{
			IntPtr hwnd = GetForegroundWindow();
			uint pid;
			GetWindowThreadProcessId(hwnd, out pid);
			Process p = Process.GetProcessById((int)pid);
			return p.MainModule.ModuleName;
		}

		public static List<string> AvailableAppNames()
		{
			// IMPLEMENT THIS
			return new List<string>() 
			{
				"notepad.exe",
				"sublime_text.exe"
			};
		}
	}
}
