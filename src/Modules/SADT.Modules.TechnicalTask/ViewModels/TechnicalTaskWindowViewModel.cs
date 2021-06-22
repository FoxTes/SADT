using Prism.Mvvm;
using SADT.Modules.TechnicalTask.Models;
using SADT.Services.FileManager;

namespace SADT.Modules.TechnicalTask.ViewModels
{
    public class TechnicalTaskWindowViewModel : BindableBase
    {
        #region Field

        private TechnicalTaskBinding _technicalTaskBinding;

        #endregion

        #region Property

        public TechnicalTaskBinding TechnicalTaskBinding
        {
            get => _technicalTaskBinding;
            set => SetProperty(ref _technicalTaskBinding, value);
        }

        #endregion

        #region Constructor

        public TechnicalTaskWindowViewModel(IFileManager fileManager)
        {
            //fileManager.DataLoadChanged += FileManager_DataLoadChanged;
            //TechnicalTaskBinding = fileManager.DataLoad.TechnicalTask;
        }

        #endregion

        #region Method

        //private void FileManager_DataLoadChanged(object sender, DataLoadEventArgs e)
        //{
        //    TechnicalTaskBinding = e.TechnicalTask;
        //}

        #endregion
    }
}
