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
            TextBox yourEmail = (TextBox)sender;
            if (yourEmail.Text == yourEmail.Tag.ToString())
            {
                yourEmail.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            TextBox yourEmail = (TextBox)sender;
            if (string.IsNullOrWhiteSpace( yourEmail.Text ) )
            {
                yourEmail.Text = yourEmail.Tag.ToString();
            }
        }
    }
}
