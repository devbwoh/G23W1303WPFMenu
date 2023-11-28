using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace G23W1303WPFMenu {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            ItemWhite.IsEnabled = false;
            ItemWhite.IsChecked = true;
            
            CommandBinding bind = new CommandBinding(ApplicationCommands.Open);
            bind.Executed += OpenDocument;
            CommandBindings.Add(bind);
        }

        private void OpenDocument(object sender, RoutedEventArgs e) {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            //dialog.FileName = "사진"; // Default file name
            dialog.DefaultExt = ".jpg"; // Default file extension
            dialog.Filter = "Images (.jpg)|*.jpg"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result != true)
                return;

            // Open document
            string filename = dialog.FileName;

            MessageBox.Show(filename);
        }

        private void SetRed(object sender, RoutedEventArgs e) {
            //MenuItem item = (MenuItem)sender;
            //item.IsChecked = true;

            BackPanel.Background = Brushes.Red;

            ItemRed.IsChecked = true;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = true;
            ItemWhite.IsChecked = false;
        }

        private void SetGreen(object sender, RoutedEventArgs e) {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = true;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = true;
            ItemWhite.IsChecked = false;
        }

        private void SetBlue(object sender, RoutedEventArgs e) {
            SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = true;

            ItemWhite.IsEnabled = true;
            ItemWhite.IsChecked = false;
        }

        private void SetWhite(object sender, RoutedEventArgs e) {
            SolidColorBrush brush = new SolidColorBrush(Colors.White);
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsEnabled = false;
            ItemWhite.IsChecked = true;
        }
    }
}
