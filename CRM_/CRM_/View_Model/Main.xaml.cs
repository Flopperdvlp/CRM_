using CRM_.View_Model;
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
namespace CRM_.View
{
    public partial class Main : Window
    {
        private MainWindowController controller;
        public Main()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            controller = new MainWindowController();  
        }
        public void Workers(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker(controller);
            addWorker.Show();
        }
        public void Workers_list(object sender, RoutedEventArgs e)
        {
            UsersTreeView.Items.Clear();

            if (controller.UsersList.Count == 0)
            {
                MessageBox.Show("No users available.");
                return;
            }

            var headerPanel = new StackPanel { Orientation = Orientation.Horizontal };
            headerPanel.Children.Add(new TextBlock { Text = "Name", Width = 100 });
            headerPanel.Children.Add(new TextBlock { Text = "Surname", Width = 100 });
            headerPanel.Children.Add(new TextBlock { Text = "Post", Width = 100 });
            headerPanel.Children.Add(new TextBlock { Text = "Phone", Width = 100 });
            UsersTreeView.Items.Add(headerPanel);

            foreach (var user in controller.UsersList)
            {
                var userItem = new TreeViewItem();
                var userPanel = new StackPanel { Orientation = Orientation.Horizontal };
                userPanel.Children.Add(new TextBlock { Text = user.Name, Width = 100 });
                userPanel.Children.Add(new TextBlock { Text = user.Surname, Width = 100 });
                userPanel.Children.Add(new TextBlock { Text = user.Post, Width = 100 });
                userPanel.Children.Add(new TextBlock { Text = user.Phone, Width = 100 });
                userItem.Header = userPanel;
                UsersTreeView.Items.Add(userItem);
            }
        }
        public void Compnay(object sender, RoutedEventArgs e)
        {
            
        }
        public void Businesses(object sender, RoutedEventArgs e)
        {

        }
        public class User
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Post { get; set; }
            public string Phone { get; set; }
        }
        public class Businesses_
        {
            public string Post { get; set; }
        }
    }
}