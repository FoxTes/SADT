using Prism.Commands;
using Prism.Events;
using SADT.Core.Enums;
using SADT.Core.EventAggregator;
using SADT.Core.Mvvm;
using SADT.DataAccess.Sqlite;
using SADT.Modules.StartWindow.Models;
using SADT.Services.FileManager;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class BeginWorkViewModel : RegionViewModelBase
    {
        private ObservableCollection<SaveProject> _saveProjects = new ObservableCollection<SaveProject>();
        private SaveProject _saveProjectSelected;

        public ObservableCollection<SaveProject> SaveProjects
        {
            get => _saveProjects;
            set => SetProperty(ref _saveProjects, value);
        }

        public SaveProject SaveProjectSelected
        {
            get => _saveProjectSelected;
            set => SetProperty(ref _saveProjectSelected, value);
        }

        public DelegateCommand<object> CreateProjectCommand { get; }

        public DelegateCommand CreateWithoutProjectCommand { get; }

        public DelegateCommand DeleteSelectProject { get; }

        public BeginWorkViewModel(IEventAggregator eventAggregator, IFileManager fileManager)
        {
            GetSaveProject().Await();

            CreateProjectCommand = new DelegateCommand<object>((type) =>
            {
                fileManager.LoadEventType = LoadEventType.NewProject;
                fileManager.TransformerType = (TransformerType)type;

                eventAggregator
                    .GetEvent<StartViewChangedEvent>()
                    .Publish("ProjectSetup");
            });
            CreateWithoutProjectCommand = new DelegateCommand(() =>
            {
                fileManager.LoadEventType = LoadEventType.Default;
                fileManager.NotificationProjectChange();

                eventAggregator
                    .GetEvent<StartViewClosedEvent>()
                    .Publish(true);
            });
            DeleteSelectProject = new DelegateCommand(() =>
            {
                DeleteSaveProject().Await(() => 
                    SaveProjects.Remove(SaveProjectSelected), (ex) =>
                    {
                        MessageBox.Show("Не удалось удалить проект.");
                    });
            });
        }

        private async Task GetSaveProject()
        {
            var getSaveProjectask = Task.Run(() =>
            {
                using var context = new Context();
                return context.LastProjects.Select(x => new SaveProject 
                {
                    TypeTransformer  = x.TypeTransformer,
                    NameProject = x.NameProject,
                    PathProject = x.PathProject,
                    DateCreate = x.DateCreate
                }).ToList();
            });
            await Task.WhenAll(getSaveProjectask);

            SaveProjects.AddRange(getSaveProjectask.Result);
        }

        private async Task DeleteSaveProject()
        {
            var deleteSaveProjectask = Task.Run(() =>
            {
                using var context = new Context();
                var project = context.LastProjects.FirstOrDefault(x => x.NameProject == SaveProjectSelected.NameProject);
                context.LastProjects.Remove(project);
                context.SaveChanges();
            });
            await Task.WhenAll(deleteSaveProjectask);
        }
    }
}