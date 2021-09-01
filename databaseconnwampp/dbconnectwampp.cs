using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace databaseconnwampp
{
    public partial class dbconnectwampp : Form
    {
            MySqlConnection con=null;
        public dbconnectwampp()
        {
            InitializeComponent();
            con = dbconnwamp.connectdb();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
         
            string gender;
            if(radioBtnmale.Checked==true)
                {
                    gender="Male" ;   
                }
            else
            {   
                    gender="Female";
            }
                
           
            try
            {
                con.Open();
                string query = "INSERT INTO `studinfo`(`id`, `name`, `gender`, `age`) VALUES ('" + textBoxid.Text + "','" + textBoxname.Text + "','" + gender + "','" + comboBoxage.SelectedItem + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted Successfully");
            }
            catch(Exception ex)
            {
              //  MessageBox.Show(""+ex);
            }
            con.Close();
        }
    }
}
