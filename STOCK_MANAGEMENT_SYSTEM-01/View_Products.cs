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

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class View_Products : Form
    {
        private const string ConnectionString = "Data Source=NEW-GEN-COMPUTE\\SQLEXPRESS; Initial Catalog=stock_system;Integrated Security=True;";

        public View_Products()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_dashboard adminPage = new Admin_dashboard();
            adminPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayProductData();
        }

            private void DisplayProductData()
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string selectQuery = "SELECT * FROM PRODUCTS";

                        using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Bind the DataTable to a new DataGridView (e.g., dataGridView2)
                                dataGridView1.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
