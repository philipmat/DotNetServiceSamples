using System.ServiceProcess;
using Common.Logging;

namespace WindowsServiceTemplate
{
    public partial class Service1 : ServiceBase
    {
        private static ILog Log = LogManager.GetLogger<Service1>();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log.Debug($"Starting {ServiceName}");
        }

        protected override void OnStop()
        {
            Log.Debug($"Stopping {ServiceName}");
        }

        protected override void OnPause()
        {
            Log.Debug($"Pausing {ServiceName}");
        }

        protected override void OnContinue()
        {
            Log.Debug($"Resuming {ServiceName}");
        }
    }
}
