using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using SQLite;

namespace AmonicProj
{
    /// <summary>
    /// Interaction logic for AddingUser.xaml
    /// </summary>
    public partial class AddingUser : Window
    {
        public AddingUser()
        {
            InitializeComponent();
            datePickerNow.SelectedDate = DateTime.Today;
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
            if (string.IsNullOrWhiteSpace(placementText.Text ) )
            {
                placementText.Text = placementText.Tag.ToString();
            }
        }

        private void btnCancel(object sender, RoutedEventArgs e)
        {
            LoginForm returnToLogin = new LoginForm();
            returnToLogin.Show();

            if (returnToLogin != null )
            {
                Close();
            }
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            AddedUsers newUsers = new AddedUsers()
            {
                Email = emailBox.Text,
                fName = fNameBox.Text,
                lName = lNameBox.Text,
                office = officeBox.Text,
                Birthdate = datePickerNow.Text,
                addUserPassword = passBox.Password
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(AddedUsesDb.databasePath))
            {
                conn.CreateTable<AddedUsers>();
                conn.Insert(newUsers);
            }
            Close();
        }
    }
}
