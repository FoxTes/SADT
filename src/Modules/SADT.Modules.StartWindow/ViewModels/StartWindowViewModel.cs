using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using SADT.Core;
using SADT.Core.EventAggregator;
using SADT.Modules.StartWindow.Views;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class StartWindowViewModel : BindableBase
    {
        private IRegionManager _scopedRegionManager;
        private bool _dialogResult;

        public IRegionManager ScopedRegionManager
        {
            get => _scopedRegionManager;
            set => SetProperty(ref _scopedRegionManager, value);
        }
    
        public bool DialogResult
        {
            get => _dialogResult;
            set => SetProperty(ref _dialogResult, value);
        }

        public StartWindowViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            eventAggregator
                .GetEvent<StartViewChangedEvent>()
                .Subscribe(nameView => ScopedRegionManager.RequestNavigate(RegionNames.StartContent, nameView));
            eventAggregator
                .GetEvent<StartViewClosedEvent>()
                .Subscribe(stage => DialogResult = stage);

            ScopedRegionManager = regionManager.CreateRegionManager();
            ScopedRegionManager.RegisterViewWithRegion(RegionNames.StartContent, typeof(BeginWork));
            ScopedRegionManager.RegisterViewWithRegion(RegionNames.StartContent, typeof(ProjectSetup));
            ScopedRegionManager.RequestNavigate(RegionNames.StartContent, "BeginWork");
        }
    }
}
