using System;
using System.Collections.ObjectModel;
using System.Windows;
using Prism.Commands;
using Prism.Ioc;
using SADT.Core.Abstractions;
using SADT.Core.Enums;
using SADT.Core.Mvvm;
using SADT.Factories;
using SADT.Models;
using SADT.Modules.StartWindow.Views;
using SADT.Services.FileManager;

namespace SADT.ViewModels
{
    /// <summary>
    /// Вью модель главного окна.
    /// </summary>
    public class MainWindowViewModel : RegionViewModelBase, ICloseWindows
    {
        private readonly IFileManager _fileManager;
        private LoadEventType _loadEventType;
        private TransformerType _typeTransformer;

        private ObservableCollection<CategoryBase> _categories = new ObservableCollection<CategoryBase>();
        private bool _canClose;

        /// <inheritdoc />
        public MainWindowViewModel(
            IContainerProvider containerProvider,
            IFileManager fileManager)
        {
            _fileManager = fileManager;
            _fileManager.ProjectChanged += (o, i) => Init();

            Init();

            CreateNewProject = new DelegateCommand(() =>
            {
                var startWindow = containerProvider.Resolve<StartWindow>();
                startWindow.ShowDialog();
            });

            ClosingWindowCommand = new DelegateCommand(() =>
            {
                var dialogResult = MessageBox.Show("Test", "Test", MessageBoxButton.YesNo);
                if (dialogResult != MessageBoxResult.Yes)
                    return;

                _canClose = true;
                Close.Invoke();
            });
        }

        /// <summary>
        /// Элементы навигационного меню.
        /// </summary>
        public ObservableCollection<CategoryBase> Categories
        {
            get => _categories;
            set => SetProperty(ref _categories, value);
        }

        /// <summary>
        /// Тип события загрузки данных для приложения.
        /// </summary>
        public LoadEventType LoadEventType
        {
            get => _loadEventType;
            set => SetProperty(ref _loadEventType, value);
        }

        /// <summary>
        /// Тип трансформатора.
        /// </summary>
        public TransformerType TypeTransformer
        {
            get => _typeTransformer;
            set => SetProperty(ref _typeTransformer, value);
        }

        /// <summary>
        /// 1.
        /// </summary>
        public Action Close { get; set; }

        /// <summary>
        /// Команда для создания нового проекта.
        /// </summary>
        public DelegateCommand CreateNewProject { get; }

        /// <summary>
        /// Событие закрытия главного окна.
        /// </summary>
        public DelegateCommand ClosingWindowCommand { get; }

        /// <inheritdoc />
        public bool CanClose()
        {
            return _canClose;
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
