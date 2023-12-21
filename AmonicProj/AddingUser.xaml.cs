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

    }
}
