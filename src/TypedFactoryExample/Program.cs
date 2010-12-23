using System;
using System.Windows.Forms;
using Castle.Windsor;
using Castle.Windsor.Installer;
using TypedFactoryExample.Controllers;

namespace TypedFactoryExample
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var container = new WindsorContainer().Install(FromAssembly.This()))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var mainController = container.Resolve<IMainController>();

                mainController.Run();

                container.Release(mainController);
            }
        }
    }
}
