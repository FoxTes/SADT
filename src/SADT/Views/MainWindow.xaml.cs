using System.Windows;
using SADT.Core.Abstractions;

namespace SADT.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <inheritdoc />
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (!(DataContext is ICloseWindows vm))
                return;

            vm.Close += Close;
            Closing += (o, args) => args.Cancel = !vm.CanClose();
        }
    }
}
