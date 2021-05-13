using SADT.Core.Enums;
using System.Windows;
using System.Windows.Controls;

namespace SADT.Selectors
{
    public class MainIconSelector : DataTemplateSelector
    {
        public DataTemplate IconTmnTemplate { get; set; }

        public DataTemplate IconTmgTemplate { get; set; }

        public DataTemplate IconTmpngTemplate { get; set; }

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
                _ => throw new System.NotImplementedException()
            };

            return selectedTemplate;
        }
    }
}
