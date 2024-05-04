using CheckWeigherFood.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckWeigherFood
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      string procName = Process.GetCurrentProcess().ProcessName;

      Process[] processes = Process.GetProcessesByName(procName);
      if (processes.Length > 1)
      {
        return;
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new FrmMain());
      AppCore.Ins.Init();
    }
  }
}
