using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Transactions : Form
    {
        private const string ConnectionString = "Data Source=NEW-GEN-COMPUTE\\SQLEXPRESS; Initial Catalog=stock_system;Integrated Security=True;";

        public Transactions()
        {
            InitializeComponent();

            // Populate the customer and product ComboBoxes on form load
            PopulateCustomerDropdown();
            PopulateProductDropdown();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill_Data BillPage = new Bill_Data();
            BillPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime transactionDate = DateTime.Now;
            int productID = ((ProductItem)comboBox2.SelectedItem).product_ID;
            int customerID = ((CustomerItem)comboBox1.SelectedItem).customer_ID;

            int quantity = int.Parse(textBox3.Text);
            //DateTime transactionDate = DateTime.Now;
            decimal price = decimal.Parse(textBox5.Text);

            if (quantity <= 0 || price <= 0)
            {
                MessageBox.Show("Please fill in valid Quantity and Price.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertTransactionsData", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Transaction_ID", 0);
                        cmd.Parameters.AddWithValue("@Customer_ID", customerID);
                        cmd.Parameters.AddWithValue("@Product_ID", productID);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Transaction_Date", transactionDate);
                        cmd.Parameters.AddWithValue("@Price", price);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Transaction data added successfully!");

                // Clear the input fields after insertion
                textBox1.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PopulateCustomerDropdown()
        {
            comboBox1.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Customer_ID FROM CUSTOMER", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customer_ID = reader.GetInt32(0);
                            comboBox1.Items.Add(new CustomerItem(customer_ID));
                        }
                    }
                }
            }
        }

        private void PopulateProductDropdown()
        {
            comboBox2.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Product_ID FROM PRODUCTS", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int product_ID = reader.GetInt32(0);
                            comboBox2.Items.Add(new ProductItem(product_ID));
                        }
                    }
                }
            }
        }

        internal class CustomerItem
        {
            public int customer_ID { get; set; }

            public CustomerItem(int customer_ID)
            {
                this.customer_ID = customer_ID;
            }
        }

        internal class ProductItem
        {
            public int product_ID { get; set; }

            public ProductItem(int product_ID)
            {
                this.product_ID = product_ID;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage homePage = new Homepage();
            homePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTransactionData();
        }
        private void DisplayTransactionData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM TRANSACTION_DATA";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to a DataGridView (e.g., dataGridView1)
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
