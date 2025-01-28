using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CRM_.View;
using CRM_.View_Model;
namespace CRM_.Controller
{
    public partial class MainWindowController : Main
    {
        public List<Businesses_> Businesses { get; set; } = new List<Businesses_>();
        public List<User> UsersList { get; set; } = new List<User>();
        public MainWindowController(){ }
        public void Add_Worker(string name, string surname, string post, string phone)
        {
            UsersList.Add(new User
            {
                Name = name,
                Surname = surname,
                Post = post,
                Phone = phone
            });
            Businesses.Add(new Businesses_ { Post = post });
            MessageBox.Show("Worker and business added");
        }
    }
}