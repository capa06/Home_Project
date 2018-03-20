using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AutoBaiduPan
{
  partial class Service : ServiceBase
  {
    public Service()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      // TODO: Add code here to start your service.
    }

    protected override void OnStop()
    {
      // TODO: Add code here to perform any tear-down necessary to stop your service.
    }

    /// <summary>
    /// Method to start the service in a console for debugging.
    /// </summary>
    /// <param name="args"></param>
    public void TestStartAndStop()
    {
      OnStart(new string[] { });
    }
  }
}
