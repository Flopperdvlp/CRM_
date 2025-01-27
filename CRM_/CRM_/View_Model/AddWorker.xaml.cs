using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CRM_.Controller;
namespace CRM_.View_Model
{
    public partial class AddWorker : Window
    {
        public AddWorker()
        {
            InitializeComponent();
        }
        public void Add_Worker(object sender, EventArgs e)
        {
            string text1 = TB1.Text;
            string text2 = TB2.Text;
            string text3 = TB3.Text;
            string text4 = TB4.Text;
        }
    }
}
