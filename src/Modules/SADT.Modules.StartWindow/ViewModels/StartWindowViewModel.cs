using Prism.Mvvm;
using Prism.Regions;
using SADT.Core;
using SADT.Modules.StartWindow.Views;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class StartWindowViewModel : BindableBase
    {
        private IRegionManager _scopedRegionManager;

        public IRegionManager ScopedRegionManager
        {
            get => _scopedRegionManager;
            set => SetProperty(ref _scopedRegionManager, value);
        }

        public StartWindowViewModel(IRegionManager regionManager)
        {
            ScopedRegionManager = regionManager.CreateRegionManager();

            ScopedRegionManager.RegisterViewWithRegion(RegionNames.StartContent, typeof(BeginWork));
            ScopedRegionManager.RegisterViewWithRegion(RegionNames.StartContent, typeof(ProjectSetup));
            ScopedRegionManager.RequestNavigate(RegionNames.StartContent, "BeginWork");
        }
    }
}
