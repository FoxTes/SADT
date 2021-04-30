using System.Windows;

namespace SADT.Modules.StartWindow.Extensions
{
    public static class DialogResultExtension
    {
        public static readonly DependencyProperty DialogResultProperty 
            = DependencyProperty.RegisterAttached("DialogResult", typeof(bool?), 
                typeof(DialogResultExtension), new PropertyMetadata(DialogResultChanged));

        private static void DialogResultChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window window)
            {
                if (window.Activate())
                    window.DialogResult = e.NewValue as bool?;
            }             
        }

        public static void SetDialogResult(Window target, bool? value)
        {
            target.SetValue(DialogResultProperty, value);
        }
    }
}
