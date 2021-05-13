using SADT.Core.Enums;
using SADT.Modules.StartWindow.Models;
using System.Windows;
using System.Windows.Controls;

namespace SADT.Modules.StartWindow.Selectors
{
    public class TypeProjectSelector : DataTemplateSelector
    {
        public DataTemplate TypeTmnTemplate { get; set; }

        public DataTemplate TypeTmgTemplate { get; set; }

        public DataTemplate TypeTmpngTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var selectedTemplate = TypeTmnTemplate;

            if (!(item is SaveProject setting))
                return selectedTemplate;

            selectedTemplate = setting.TypeTransformer switch
            {
                TransformerType.Tm => TypeTmnTemplate,
                TransformerType.Tmn => TypeTmnTemplate,
                TransformerType.Tmg => TypeTmgTemplate,
                TransformerType.Tmpng => TypeTmpngTemplate,
                _ => TypeTmpngTemplate,
            };

            return selectedTemplate;
        }
    }
}
