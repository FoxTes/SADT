using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Ioc;
using SADT.Core.Enums;
using SADT.Core.Mvvm;
using SADT.Factorys;
using SADT.Models;
using SADT.Modules.StartWindow.Views;
using SADT.Services.FileManager;
using SADT.Services.Notifications;

namespace SADT.ViewModels
{
    public class MainWindowViewModel : RegionViewModelBase
    {
        private readonly IFileManager _fileManager;
        private LoadEventType _loadEventType;
        private TransformerType _typeTransformer;

        private ObservableCollection<CategoryBase> _categories = new ObservableCollection<CategoryBase>();

        public ObservableCollection<CategoryBase> Categories
        {
            get => _categories;
            set => SetProperty(ref _categories, value);
        }
        
        public LoadEventType LoadEventType
        {
            get => _loadEventType;
            set => SetProperty(ref _loadEventType, value);
        }
 
        public TransformerType TypeTransformer
        {
            get => _typeTransformer;
            set => SetProperty(ref _typeTransformer, value);
        }

        public DelegateCommand CreateNewProject { get; }

        public MainWindowViewModel(IContainerProvider containerProvider, IFileManager fileManager, INotificationService notificationService)
        {
            _fileManager = fileManager;
            _fileManager.ProjectChanged += (o, i) => Init();

            Init();

            CreateNewProject = new DelegateCommand(() =>
            {
                notificationService.ShowNotification(message: "Привет");

                //var startWindow = containerProvider.Resolve<StartWindow>();
                //startWindow.ShowDialog();
            });
            //notificationService.ShowNotification(message: "Привет");
        }

        private void Init()
        {
            _typeTransformer = _fileManager.TransformerType;
            _loadEventType = _fileManager.LoadEventType;

            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            if (LoadEventType == LoadEventType.Default)
                Categories.Clear();
            else
                Categories = new ItemMenuFactory().CreateItems(_typeTransformer).GetItemsMenu();
        }
    }
}
