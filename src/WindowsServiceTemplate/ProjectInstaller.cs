using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsServiceTemplate
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            // https://stackoverflow.com/a/37992650
            using(var sc = new System.ServiceProcess.ServiceController(serviceInstaller1.ServiceName))
            {
                sc.Start();
            }
        }

        private void serviceInstaller2_AfterInstall(object sender, InstallEventArgs e)
        {
            var serviceName = serviceInstaller2.ServiceName;
            try
            {
                if (!EventLog.SourceExists(serviceName))
                {
                    EventLog.CreateEventSource(serviceName, "Log");
                    // note - it takes a while to create the source so we won't be able to use it till probably next restart
                }
            }
            catch (System.Security.SecurityException secEx)
            {
                Trace.WriteLine($"Security exception creating Event log source {serviceName}. You probably don't have permissions.");
            }

            using(var sc = new System.ServiceProcess.ServiceController(serviceName))
            {
                sc.Start();
            }
        }
    }
}
