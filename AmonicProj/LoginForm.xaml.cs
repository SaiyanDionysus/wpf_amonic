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

namespace AmonicProj
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit(object sender, RoutedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Environment.Exit(0);
        }

        private void btnLogin(object sender, RoutedEventArgs e)
        {
            var Username = txtUsername.Text;
            var Password = txtPassword.Password;

            using (UserContext context = new UserContext())
            {
                bool userfound = context.Users.Any(user => user.UserName == Username && user.Password == Password);

                if (userfound)
                {
                    GrantAccess();
                    Close();
                } else
                {
                    MessageBox.Show("Неверно введены данные или такого пользователя не существует!");
                }
            }
        }
        public void GrantAccess()
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
        }
    }
}
