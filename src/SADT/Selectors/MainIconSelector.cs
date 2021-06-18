using System;
using System.Windows;
using System.Windows.Controls;
using SADT.Core.Enums;

namespace SADT.Selectors
{
    /// <summary>
    /// Селектор иконки приложения.
    /// </summary>
    public class MainIconSelector : DataTemplateSelector
    {
        /// <summary>
        /// Тип трансформатора ТМН.
        /// </summary>
        public DataTemplate IconTmnTemplate { get; set; }

        /// <summary>
        /// Тип трансформатора ТМГ.
        /// </summary>
        public DataTemplate IconTmgTemplate { get; set; }

        /// <summary>
        /// Тип трансформатора ТМПНГ.
        /// </summary>
        public DataTemplate IconTmpngTemplate { get; set; }

        /// <summary>
        /// Селектор шаблона.
        /// </summary>
        /// <param name="item">Тип трансформатора.</param>
        /// <param name="container">Контейнер.</param>
        /// <returns>Шаблон.</returns>
        /// <exception cref="NotImplementedException">Нет реализации.</exception>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var selectedTemplate = IconTmnTemplate;

            if (!(item is TransformerType transformerType))
                return selectedTemplate;

            selectedTemplate = transformerType switch
            {
                TransformerType.Tm => IconTmnTemplate,
                TransformerType.Tmn => IconTmnTemplate,
                TransformerType.Tmg => IconTmgTemplate,
                TransformerType.Tmpng => IconTmpngTemplate,
                _ => throw new NotImplementedException()
            };

            return selectedTemplate;
        }
    }
}
