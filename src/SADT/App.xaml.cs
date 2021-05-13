using Prism.Ioc;
using Prism.Modularity;
using SADT.DataAccess.Sqlite;
using SADT.Modules.StartWindow.Views;
using SADT.Services.FileManager;
using SADT.Services.Notifications;
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
            containerRegistry.RegisterSingleton<INotificationService, NotificationService>();
            containerRegistry.RegisterSingleton<IFileManager, FileManager>();
        }

        protected override void OnInitialized()
        {
            CreateDatabase();

            var inputArg = GetInputCommandArgs();
            if (inputArg == null)
            {
                var startWindow = Container.Resolve<StartWindow>();
                var result = startWindow.ShowDialog();

                if ((bool)!result)
                    Current.Shutdown();
            }
            base.OnInitialized();
        }

        private static string GetInputCommandArgs()
        {
            var args = Environment.GetCommandLineArgs();
            return args.Length > 1 ? args[1] : null;
        }

        private void CreateDatabase()
        {
            using var context = new Context();
            context.Database.EnsureCreated();
        }
    }
}
