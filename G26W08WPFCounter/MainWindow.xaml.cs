using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace G26W08WPFCounter {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private
            int count = 0;
        public MainWindow() {
            InitializeComponent();
        }

        private void OnAdd(object sender, RoutedEventArgs e) {
            TxtCount.Text = $"{++count}";
        }

        private void OnDown(object sender, RoutedEventArgs e) {
            if (count > 0) {
                TxtCount.Text = $"{--count}";
            }
        }
    }
}