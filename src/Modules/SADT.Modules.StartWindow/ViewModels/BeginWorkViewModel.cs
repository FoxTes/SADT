using Prism.Commands;
using Prism.Regions;
using SADT.Core;
using SADT.Core.Enums;
using SADT.Core.Mvvm;
using SADT.Modules.StartWindow.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class BeginWorkViewModel : RegionViewModelBase
    {
        private readonly IRegionManager _regionManager;
        private ObservableCollection<SavedProjects> _saveProjects = new ObservableCollection<SavedProjects>();

        public ObservableCollection<SavedProjects> SaveProjects
        {
            get { return _saveProjects; }
            set { SetProperty(ref _saveProjects, value); }
        }

        public DelegateCommand CreateProjectCommand { get; private set; }

        public BeginWorkViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            var savedProjects = Enumerable.Range(0, 4)
                .Select(x => new SavedProjects
                {
                    TypeTransformer = TypeTransformer.TMG,
                    DateCreate = DateTime.Now.AddDays(x),
                    PathToProject = @$"C:\Users\GLevchenko\Downloads\Telegram Desktop\\Telegram Desktop\Project{x}"
                })
                .ToList();
            SaveProjects.AddRange(savedProjects);

            CreateProjectCommand = new DelegateCommand(CreateProjectSubmit);
        }

        private void CreateProjectSubmit()
        {

        }
    }
}
