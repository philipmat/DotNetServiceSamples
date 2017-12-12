using System.Diagnostics;
using System.Security;
using System.ServiceProcess;

namespace WindowsServiceTemplate
{
    partial class Service2 : ServiceBase
    {
        private EventLog _log;
        public Service2()
        {
            InitializeComponent();
            var sourceExists = false;
            try
            {
                if (!EventLog.SourceExists(ServiceName))
                {
                    EventLog.CreateEventSource(ServiceName, "Log");
                    // note - it takes a while to create the source so we won't be able to use it till probably next restart
                    // should've been created during install
                }
                else
                {
                    sourceExists = true;
                }
            }
            catch (SecurityException secEx)
            {
                Trace.WriteLine($"Security exception creating Event log source {ServiceName}. You probably don't have permissions.");
            }

            if (sourceExists)
            {
                _log = new EventLog();
                _log.Source = ServiceName;
            }
        }

        protected override void OnStart(string[] args)
        {
            _log?.WriteEntry($"{ServiceName} starting.");
        }

        protected override void OnStop()
        {
            _log?.WriteEntry($"{ServiceName} stopping.");
        }
    }
}
