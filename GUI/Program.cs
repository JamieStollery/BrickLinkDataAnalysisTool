using Autofac;
using Autofac.Core;
using GUI.View.Stage;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static partial class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterModule<IoCModule>();
            var container = builder.Build();

            using(var scope = container.BeginLifetimeScope())
            {
                // Resolve main stage presenter
                var presenter = scope.Resolve<MainStagePresenter>();

                // Open main stage
                presenter.OpenStage();

                // Run application
                Application.Run();
            }

        }
    }
}
