using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medtech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\db_account.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count (*) from tableLogin where Username = '" + textBox_Usr_name.Text + "' and Password = '" + textBox_pass.Text + "'",con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                Form2 main = new Form2();
                main.Show();
            }
            else {
                MessageBox.Show("User name or password is incorrect Try again");
            }
        }
    }
}
