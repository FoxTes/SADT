using SADT.Models;
using System.Windows;
using System.Windows.Controls;

namespace SADT.Selectors
{
    public class MenuItemSelector : DataTemplateSelector
    {
        public DataTemplate DefaultCategoryTemplate { get; set; }

        public DataTemplate SeparatorTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var selectedTemplate = DefaultCategoryTemplate;

            if (!(item is CategoryBase setting))
                return selectedTemplate;

            selectedTemplate = setting switch
            {
                CategoryDefault _ => DefaultCategoryTemplate,
                Models.Separator _ => SeparatorTemplate,
                _ => selectedTemplate
            };

            return selectedTemplate;
        }
    }
}
