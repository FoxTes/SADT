using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using SADT.Core.Enums;
using SADT.Core.EventAggregator;
using SADT.Core.Mvvm;
using SADT.DataAccess.Sqlite;
using SADT.DataAccess.Sqlite.Entitys;
using SADT.Services.FileManager;
using System;
using System.Threading.Tasks;
using SADT.Services.FIleDialog;

namespace SADT.Modules.StartWindow.ViewModels
{
    public class ProjectSetupViewModel : RegionViewModelBase
    {
        private readonly IFileManager _fileManager;

        private string _nameProject;
        private string _pathProject;

        public string NameProject
        {
            get => _nameProject;
            set => SetProperty(ref _nameProject, value);
        }

        public string PathProject
        {
            get => _pathProject;
            set => SetProperty(ref _pathProject, value);
        }

        public DelegateCommand BackCommand { get; }

        public DelegateCommand CreateProjectCommand { get; }

        public DelegateCommand ChangePathProject { get; }

        public ProjectSetupViewModel(
            IEventAggregator eventAggregator, 
            IFileManager fileManager,
            IFileDialog fileDialog)
        {
            _fileManager = fileManager;

            PathProject = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            BackCommand = new DelegateCommand(() =>
            {
                _fileManager.LoadEventType = LoadEventType.Default;

                eventAggregator
                    .GetEvent<StartViewChangedEvent>()
                    .Publish("BeginWork");
            });
            CreateProjectCommand = new DelegateCommand(() =>
            {
                SaveProject().Await(() => {
                    _fileManager.NotificationProjectChange();
                    eventAggregator
                        .GetEvent<StartViewClosedEvent>()
                        .Publish(true); }, ex =>
                        {
                            System.Windows.MessageBox.Show("Не удалось создать проект.");
                        });
            });
            ChangePathProject = new DelegateCommand(() =>
            {
                if (fileDialog.FolderBrowserDialog())
                    PathProject = fileDialog.FilePath;
            });
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            NameProject = $"{_fileManager.TransformerType}_Project";

            base.OnNavigatedTo(navigationContext);
        }

        private async Task SaveProject()
        {
            var saveProjectTask = Task.Run(() =>
            {
                using var context = new Context();
                var project = new LastProject
                {
                    TypeTransformer = _fileManager.TransformerType,
                    NameProject = NameProject,
                    PathProject = PathProject,
                    DateCreate = DateTime.Now
                };
                context.LastProjects.Add(project);
                context.SaveChanges();
            });
            await Task.WhenAll(saveProjectTask);
        }
    }
}
