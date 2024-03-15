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

namespace Auftragserfassung {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            var a = new Auftrag();
            a.Kunde = new Kunde();
            this.DataContext = a;

            AuftragDataGrid.ItemsSource = Auftrag.selectAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var a = new Auftrag();
            a.Kunde = new Kunde();
            this.DataContext = a;
        }

    }
}