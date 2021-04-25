using Prism.Ioc;
using Prism.Modularity;
using SADT.Modules.StartWindow.Views;
using SADT.Views;
using System;
using System.Windows;

namespace SADT
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void OnInitialized()
        {
            var inputArg = GetInputCommandArgs();
            if (inputArg == null)
            {
                var startWindow = Container.Resolve<StartWindow>();
                var result = startWindow.ShowDialog();
            }
            base.OnInitialized();
        }

        private static string GetInputCommandArgs()
        {
            var args = Environment.GetCommandLineArgs();
            return args.Length > 1 ? args[1] : null;
        }
    }
}
