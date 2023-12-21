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
            //MainWindow mainWin = new MainWindow();
            //mainWin.Show();
            AddingUser addUser = new AddingUser();
            addUser.Show();
        }

        public void RemoveText(object sender, EventArgs e)
        {
            TextBox placementText = (TextBox)sender;
            if (placementText.Text == placementText.Tag.ToString())
            {
                placementText.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            TextBox placementText = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(placementText.Text))
            {
                placementText.Text = placementText.Tag.ToString();
            }
        }
    }
}
