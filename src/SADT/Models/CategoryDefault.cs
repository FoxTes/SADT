using System.Collections.ObjectModel;

namespace SADT.Models
{
    /// <summary>
    /// Стандартный элемент навигационного меню.
    /// </summary>
    public class CategoryDefault : CategoryBase
    {
        /// <summary>
        /// Указывает выбран ли этот элемент в меню.
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// Имя элемента.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Название модуля.
        /// </summary>
        /// <remarks>
        /// Используется для навигации.
        /// </remarks>
        public string NameModule { get; set; }

        /// <summary>
        /// Иконка элемента.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Вложенные элементы.
        /// </summary>
        public ObservableCollection<CategoryDefault> Children { get; set; }
    }
}
