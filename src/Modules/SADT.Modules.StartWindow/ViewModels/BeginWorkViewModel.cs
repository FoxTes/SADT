using Prism.Mvvm;
using SADT.Core.Enums;
using SADT.Modules.StartWindow.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class BeginWorkViewModel : BindableBase
    {
        private ObservableCollection<SavedProjects> _saveProjects = new ObservableCollection<SavedProjects>();
        public ObservableCollection<SavedProjects> SaveProjects
        {
            get { return _saveProjects; }
            set { SetProperty(ref _saveProjects, value); }
        }

        public BeginWorkViewModel()
        {
            SaveProjects.Add(new SavedProjects
            {
                TypeTransformer = TypeTransformer.TMPNG,
                DateCreate = DateTime.Now.AddDays(1),
                PathToProject = @$"C:\Users\GLevchenko\Downloads\Telegram Desktop\Project{1}"
            });
            var savedProjects = Enumerable.Range(0, 4)
                .Select(x => new SavedProjects
                {
                    TypeTransformer = TypeTransformer.TMG,
                    DateCreate = DateTime.Now.AddDays(x),
                    PathToProject = @$"C:\Users\GLevchenko\Downloads\Telegram Desktop\\Telegram Desktop\Project{x}"
                })
                .ToList();
            SaveProjects.AddRange(savedProjects);
            SaveProjects.Add(new SavedProjects
            {
                TypeTransformer = TypeTransformer.TMPNG,
                DateCreate = DateTime.Now.AddDays(1),
                PathToProject = @$"C:\Users\GLevchenko\Downloads\Telegram Desktop\Project{1}"
            });
            SaveProjects.Add(new SavedProjects
            {
                TypeTransformer = TypeTransformer.TMN,
                DateCreate = DateTime.Now.AddDays(1),
                PathToProject = @$"C:\Users\GLevchenko\Downloads\Telegram Desktop\Project{1}"
            });
            SaveProjects.AddRange(savedProjects);
        }
    }
}
