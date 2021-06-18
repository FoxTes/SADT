using System;
using System.Windows;
using System.Windows.Controls;
using SADT.Models;

namespace SADT.Selectors
{
    /// <summary>
    /// Селектор элементов меню.
    /// </summary>
    public class MenuItemSelector : DataTemplateSelector
    {
        /// <summary>
        /// Стандартный элемент навигационного меню.
        /// </summary>
        public DataTemplate DefaultCategoryTemplate { get; set; }

        /// <summary>
        /// Разделитель навигационного меню.
        /// </summary>
        public DataTemplate SeparatorTemplate { get; set; }

        /// <summary>
        /// Селектор шаблона.
        /// </summary>
        /// <param name="item">Элемент навигационного меню.</param>
        /// <param name="container">Контейнер.</param>
        /// <returns>Шаблон.</returns>
        /// <exception cref="NotImplementedException">Нет реализации.</exception>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var selectedTemplate = DefaultCategoryTemplate;

            if (!(item is CategoryBase setting))
                return selectedTemplate;

            selectedTemplate = setting switch
            {
                CategoryDefault _ => DefaultCategoryTemplate,
                Models.Separator _ => SeparatorTemplate,
                _ => throw new NotImplementedException()
            };

            return selectedTemplate;
        }
    }
}
