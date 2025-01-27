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
using CRM_.Controller;

namespace CRM_
{
    public partial class MainWindow : Window
    {
        private LogIn _logInController;
        public MainWindow()
        {
            InitializeComponent();
            _logInController = new LogIn(this); 
        }
        public void LogIn(object sender, RoutedEventArgs e)
        {
            string textbox1 = TB1.Text;
            string textbox2 = TB2.Text;
            _logInController.LogIn_(textbox1, textbox2);
        }
    }
}