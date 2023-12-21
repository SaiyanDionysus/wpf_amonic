using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmonicProj
{
    public partial class AddedUsesDb : AddedUsers
    {
        static string dbName = "AddedUsers.db";
        static string folderPath = "C:\\Users\\Denis\\source\\repos\\wpf_amonic\\AmonicProj\\bin\\Debug\\net8.0-windows8.0";
        public static string databasePath = System.IO.Path.Combine(folderPath, dbName);
    }
}
