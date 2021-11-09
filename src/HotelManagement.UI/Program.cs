using System;
using System.Windows.Forms;
using HotelManagement.Application;
using HotelManagement.Application.DependencyInjection;
using HotelManagement.Infrastructure;
using HotelManagement.UI.Contracts;
using HotelManagement.UI.Utilities;
using HotelManagement.UI.Views.Room;

namespace HotelManagement.UI
{
    static class Program
    {
        public static IContainer Container { get; } = new Container();
        private static void Configuration()
        {
            Container.Register<IConfirm, Confirm>();
            Container.Register<FrmMainRoom>();
            Container.Register<FrmCreateRoom>();
            Container.Register<FrmUpdateRoom>();

            Container.ConfigureInfrastructureServices();
            Container.ConfigureApplicationServices();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration();
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Main());
        }
    }
}
