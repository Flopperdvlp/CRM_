using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CRM_.View;
namespace CRM_.Controller
{
    public partial class LogIn
    {
        private readonly Window _currentWindow;
        public LogIn(Window currentWindow)
        {
            _currentWindow = currentWindow;
        }
        public void LogIn_(string text1, string text2)
        {
            if (text1 == "admin" && text2 == "admin") NextWindow();
            else MessageBox.Show("Y entered wrong login or password");
        }
        public void NextWindow()
        {
            Main main = new Main();
            main.Show();
            _currentWindow.Hide();
        }
    }
}