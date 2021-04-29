using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using SADT.Core.Enums;
using SADT.Core.EventAggregator;
using SADT.Core.Mvvm;
using SADT.Modules.StartWindow.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class BeginWorkViewModel : RegionViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        private ObservableCollection<SavedProjects> _saveProjects = new ObservableCollection<SavedProjects>();

        public ObservableCollection<SavedProjects> SaveProjects
        {
            get { return _saveProjects; }
            set { SetProperty(ref _saveProjects, value); }
        }

        public DelegateCommand CreateProjectCommand { get; private set; }

        public BeginWorkViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            CreateProjectCommand = new DelegateCommand(CreateProjectSubmit);
        }

        private void CreateProjectSubmit()
        {
            _eventAggregator.GetEvent<StartViewChangedEvent>().Publish("ProjectSetup");
        }
    }
}
