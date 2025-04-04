using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceReview
{
    public partial class Service: ServiceBase
    {
        public Timer T;

        public Service()
        {
            InitializeComponent();
            T = new Timer(30000);
            T.Elapsed += T_Elapsed;
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            DAL D = new DAL();
            D.Insert("Servis calisti", DateTime.Now);

        }

        protected override void OnStart(string[] args)
        {
            // servis calistiginda calisir
            T.Start();
        }

        protected override void OnPause()
        {
            //servis gecici olarak durduruldugunda calisacak metot
            T.Stop();
        }

        protected override void OnContinue()
        {
            // pause isleminden sonra devam ettirildiginde calisacak metot
            T.Start();
        }

        protected override void OnStop()
        {
            // servis durduruldugunda calisacak metot
            T.Stop();
        }

        protected override void OnShutdown()
        {
            // bilgisayar kapandiginda(shut down oldugunda) calisacak metot
            T.Stop();
        }
    }
}
