using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace BindSense
{
    public class MacroPattern
    {
        private Dictionary<string, string> keyMap;
        public MacroPattern()
        {
            this.keyMap = new Dictionary<string, string>();
        }
        public MacroPattern(Dictionary<string, string> map)
        {
            this.keyMap = map;
        }
        public void fire(string command)
        {
            SendKeys.SendWait(keyMap[command]);
        }
    }
    public class ApplicationMatcher
    {

        private const int nChars = 256;
        private Dictionary<string, MacroPattern> patternMap =
            new Dictionary<string, MacroPattern>();
        public ApplicationMatcher()
        {
            this.patternMap["__default"] = new MacroPattern();
        }
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);
        public void setPattern(MacroPattern pattern, string appName = "__default")
        {
            patternMap[appName] = pattern;
        }
        public void fire(string command)
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            string name = p.MainModule.ModuleName;
            System.Console.WriteLine(name);
            if (patternMap.ContainsKey(name))
                patternMap[name].fire(command);
            else
                patternMap["__default"].fire(command);


        }
    }
}
