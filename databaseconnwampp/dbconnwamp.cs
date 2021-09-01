using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace databaseconnwampp
{
    class dbconnwamp
    {
        public static MySqlConnection connectdb()
        {
            try
            {
                string server = "localhost";
                string database = "testdbconncsharpwampp";
                string uid = "root";
                    string password="";
                    string connectionstring;
               connectionstring="SERVER="+server+";"+"DATABASE="+database+";"+"USERNAME="+uid+";"+"PASSWORD="+password+";";
               MySqlConnection connect=new MySqlConnection(connectionstring);
                return connect;
            }
            catch(MySqlException ex)
            {
               // MessageBox.Show("ERROR "+ ex);
                    return null;
            }
        }
    }
}
