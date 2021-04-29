using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using SADT.Core.EventAggregator;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class ProjectSetupViewModel : BindableBase
    {
        public DelegateCommand BackCommand { get; private set; }

        public ProjectSetupViewModel(IEventAggregator eventAggregator)
        {
            BackCommand = new DelegateCommand(() 
                => eventAggregator.GetEvent<StartViewChangedEvent>()
                                  .Publish("BeginWork"));
        }
    }
}
