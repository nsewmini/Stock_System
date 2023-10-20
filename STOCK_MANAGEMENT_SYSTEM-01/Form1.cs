
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NEW-GEN-COMPUTE\\SQLEXPRESS; Initial Catalog=stock_system; Integrated Security=true; Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //MessageBox.Show("Login Success");
                Admin_dashboard adminPage = new Admin_dashboard();
                adminPage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }

            con.Close();
        }

    }
}