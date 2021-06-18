using System.Collections.ObjectModel;
using SADT.Models;

namespace SADT.Factories
{
    /// <inheritdoc/>
    internal class TmpngItemMenu : IItemMenu
    {
        /// <inheritdoc/>
        public ObservableCollection<CategoryBase> GetItemsMenu()
        {
            return new ObservableCollection<CategoryBase>
            {
                new CategoryDefault
                {
                    IsSelected = true,
                    Name = "Техническое задание №2",
                    Icon =
                        "M14,2H6C4.9,2,4.01,2.9,4.01,4L4,20c0,1.1,0.89,2,1.99,2H18c1.1,0,2-0.9,2-2V8L14,2z M18,20H6V4h7v5h5V20z M8.82,13.05 L7.4,14.46L10.94,18l5.66-5.66l-1.41-1.41l-4.24,4.24L8.82,13.05z",
                    NameModule = "TechnicalTaskWindow"
                },
                new Separator()
            };
        }
    }
}