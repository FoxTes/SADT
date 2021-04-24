using Prism.Ioc;
using Prism.Modularity;
using SADT.Views;
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
    }
}
