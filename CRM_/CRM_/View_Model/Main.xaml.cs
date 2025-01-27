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

namespace CRM_.View
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        public void Workers(object sender, EventArgs e)
        {

        }
        public class User
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Post { get; set; }
            public string Phone { get; set; }
        }
        public class Businesses
        {
            public string Post { get; set; }
        }
    }
}
