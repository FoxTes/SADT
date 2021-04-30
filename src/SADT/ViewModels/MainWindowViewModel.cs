using Prism.Commands;
using Prism.Ioc;
using SADT.Core.Enums;
using SADT.Core.Mvvm;
using SADT.Modules.StartWindow.Views;

namespace SADT.ViewModels
{
    public class MainWindowViewModel : RegionViewModelBase
    {
        private LoadEventType _loadEventType;
        private TransformerType _typeTransformer;

        public LoadEventType LoadEventType
        {
            get { return _loadEventType; }
            set { SetProperty(ref _loadEventType, value); }
        }
 
        public TransformerType TypeTransformer
        {
            get { return _typeTransformer; }
            set { SetProperty(ref _typeTransformer, value); }
        }

        public DelegateCommand CreateNewProject { get; }

        public MainWindowViewModel(IContainerProvider containerProvider)
        {
            CreateNewProject = new DelegateCommand( () => 
            {
                var startWindow = containerProvider.Resolve<StartWindow>();
                var result = startWindow.ShowDialog();
            });
        }
    }
}
