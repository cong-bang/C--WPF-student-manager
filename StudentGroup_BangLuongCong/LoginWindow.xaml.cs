using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Application = System.Windows.Application;

namespace StudentGroup_BangLuongCong
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Trường hợp ko nhập gì mà ấn Login Button
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                System.Windows.MessageBox.Show("Please input username and password!", "Input please", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            UserRoleService service = new UserRoleService();
            UserRole? acc = service.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (acc == null)
            {
                System.Windows.MessageBox.Show("Login failed! Invalid Username or Password!", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //check role là staff 
            if (acc.UserRole1 != 2)
            {
                System.Windows.MessageBox.Show("You have not permission to access this application!", "Wrong privilege", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            MainWindow f = new MainWindow();
            f.Show();
            this.Hide();
            
        }
    }
}
