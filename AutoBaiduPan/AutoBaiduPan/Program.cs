using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;
//using CommandLine;

namespace AutoBaiduPan
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          Service ServicesToRun = new Service();
          if (Environment.UserInteractive || args.Contains("-c", StringComparer.InvariantCultureIgnoreCase) || args.Contains("-console", StringComparer.InvariantCultureIgnoreCase))
          {
            ServicesToRun.TestStartAndStop();
          }
          else
          {
            ServiceBase.Run(ServicesToRun);
          }
    }
    }
}
