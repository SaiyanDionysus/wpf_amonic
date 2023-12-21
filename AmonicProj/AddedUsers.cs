using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AmonicProj
{
    //there is a code which will be adding users in the AddingUser.xaml form

    public class AddedUsers
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string office { get; set; }
        public string Birthdate { get; set; }
        public string addUserPassword { get; set; }
    }
}
