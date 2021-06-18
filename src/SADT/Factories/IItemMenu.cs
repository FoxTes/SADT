using System.Collections.ObjectModel;
using SADT.Models;

namespace SADT.Factories
{
    /// <summary>
    /// Элементы меню.
    /// </summary>
    internal interface IItemMenu
    {
        /// <summary>
        /// Получить элементы меню.
        /// </summary>
        /// <returns>
        /// Коллекция элементов навигационного меню.
        /// </returns>
        ObservableCollection<CategoryBase> GetItemsMenu();
    }
}
