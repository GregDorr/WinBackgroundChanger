using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BackgroundSharp
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        static void Main(string[] args)
        {

            IntPtr bptr = Marshal.StringToCoTaskMemUni(Path.Combine(Environment.CurrentDirectory, "TEST.png"));

            SystemParametersInfoW(0x0014, 0, bptr, 0x0001);

            Marshal.FreeCoTaskMem(bptr);
        }
    }
}
