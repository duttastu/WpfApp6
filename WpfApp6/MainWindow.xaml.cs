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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
           /* MessageBox.Show("Helloo World","box",MessageBoxButton.OK,MessageBoxImage.Asterisk);*/
           MessageBoxResult result = MessageBox.Show("Do you agree", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agree";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }
        }
    }
}