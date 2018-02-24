#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SecureBinCore.Engine.ProcessManager
{
    public class StartProcess : IProcess
    {
        string ProcessName;
        public StartProcess(string processName)
        {
            ProcessName = processName;
        }
        public void RunProcess()
        {
            Process NewProcess = new Process();
            NewProcess.StartInfo.UseShellExecute = true;
            NewProcess.StartInfo.FileName = ProcessName;
            NewProcess.Start();
        }
    }
}

#endregion