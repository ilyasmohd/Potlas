using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Winforms_SqlConnection
{
    public partial class Form1 : Form
    {
        private DataSet dsAllTables;
        //https://www.guru99.com/c-sharp-access-database.html
        //https://docs.microsoft.com/en-us/biztalk/adapters-and-accelerators/adapter-sql/executenonquery-executereader-and-executescalar-using-the-sql-adapter
        //https://docs.microsoft.com/en-us/dotnet/api/system.data.dataset?redirectedfrom=MSDN&view=netframework-4.7.2
        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql/sqltypes-and-the-dataset
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["sqlCon"]);

            SqlConnection sqlConnection = new SqlConnection("Data Source=E15510S1L;Initial Catalog=TestDB2;Integrated Security=SSPI;");
            SqlCommand command = new SqlCommand("SELECT top 2 [CustomerID],[CustomerName] FROM [dbo].[Customers]", sqlConnection);
            command.CommandType = CommandType.Text;

            //SqlConnectionStringBuilder sConnB = new SqlConnectionStringBuilder();
            //sConnB.DataSource = ""; sConnB.InitialCatalog = ""; sConnB.UserID = ""; sConnB.Password = "";

            //SqlConnection sqlConnection123 = new SqlConnection(sConnB.ConnectionString);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                label1.Text = sqlDataReader.GetInt32(0).ToString();
                //label1.Text = "100";
                label2.Text = sqlDataReader.GetString(1);
            }

            sqlConnection.Close();
        }

        public void InsertCustomer()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=E15510S1L;Initial Catalog=TestDB2;Integrated Security=SSPI;");
            //SqlCommand command = new SqlCommand(" insert into Customers values ( " + txtID.Text + ",'" + txtName.Text + "', '" + txtAddress.Text + "') ", sqlConnection);
            SqlCommand command = new SqlCommand(" insert into Customers values (@ID, @Name, @Address) ", sqlConnection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Address", txtAddress.Text);


            sqlConnection.Open();
            int resul = command.ExecuteNonQuery();
            sqlConnection.Close();

            if (resul == 0)
            {
                MessageBox.Show("not inserted");
            }
            else
            {
                MessageBox.Show("inserted succesfully");

            }
        }

        public void ScalarExample()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=E15510S1L;Initial Catalog=TestDB2;Integrated Security=SSPI;");
            SqlCommand command = new SqlCommand("select count(*) from customers", sqlConnection);
            command.CommandType = CommandType.Text;

            sqlConnection.Open();
            object i = command.ExecuteScalar();
            sqlConnection.Close();
            MessageBox.Show("the no of rows are: " + Convert.ToInt32(i).ToString());

        }

        public void StoredProcedureExample()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=E15510S1L;Initial Catalog=TestDB2;Integrated Security=SSPI;");
            SqlCommand command = new SqlCommand("NoofCustomers", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            //Old
            //sqlConnection.Open();
            //object i = command.ExecuteScalar();
            //SqlDataReader sqlDataReader = command.ExecuteReader();
            //DataTable dt = new DataTable();

            //dt.Columns.Add("CustomerID", typeof(Int32));
            //dt.Columns.Add("CustomerName", typeof(string));
            //dt.Columns.Add("CustAddress", typeof(string));

            //while (sqlDataReader.Read())
            //{
            //    dt.Rows.Add(Convert.ToInt32(sqlDataReader["CustomerId"]), sqlDataReader.GetString(1), sqlDataReader.GetString(2));
            //}

            //dgvCustomers.DataSource = dt;
            //sqlConnection.Close();


            //New
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvCustomers.DataSource = dt;


            //MessageBox.Show(Convert.ToInt32(i).ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertCustomer();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            StoredProcedureExample();
        }

        private void btnScalarExample_Click(object sender, EventArgs e)
        {
            ScalarExample();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDB2DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.testDB2DataSet.Customers);
            DataSetExample();
        }

        public void DataSetExample()
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=E15510S1L;Initial Catalog=TestDB2;Integrated Security=SSPI;"))
            {
                SqlCommand command = new SqlCommand("select * from customers", sqlConnection);
                command.CommandType = CommandType.Text;

                SqlCommand command2 = new SqlCommand("select * from Orders", sqlConnection);
                command2.CommandType = CommandType.Text;

                SqlCommand command3 = new SqlCommand("select * from testTable", sqlConnection);
                command3.CommandType = CommandType.Text;

                DataSet ds = new DataSet("multipleTalbes");

                ds.Tables.Add("Customers"); ds.Tables.Add("Orders"); ds.Tables.Add("testTable");

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds, "Customers");


                SqlDataAdapter da2 = new SqlDataAdapter(command2);
                da2.Fill(ds,"Orders");

                SqlDataAdapter da3 = new SqlDataAdapter(command3);
                da3.Fill(ds, "testTable");

                //dgvAllTables.DataSource = ds;
                dsAllTables = ds;
            }
        }

        private void btnAllTables_Click(object sender, EventArgs e)
        {
            dgvAllTables.DataSource = dsAllTables.Tables["Customers"];
        }

        private void orders_Click(object sender, EventArgs e)
        {
            dgvAllTables.DataSource = dsAllTables.Tables["Orders"];
        }

        private void btnTestRead_Click(object sender, EventArgs e)
        {
            dgvAllTables.DataSource = dsAllTables.Tables["testTable"];
        }
    }

}

/*
SqlConnection conn = new SqlConnection();
conn.ConnectionString =
"Data Source=ServerName;" +
"Initial Catalog=DataBaseName;" +
"User id=UserName;" +
"Password=Secret;";
conn.Open();
// .NET DataProvider -- Trusted Connection

SqlConnection conn = new SqlConnection();
conn.ConnectionString =
"Data Source=ServerName;" +
"Initial Catalog=DataBaseName;" +
"Integrated Security=SSPI;";
conn.Open();*/

//SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
//SqlCommand cmd = new SqlCommand("select * from tbl_data", con);
//con.Open();  
//                SqlDataAdapter sda = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sda.Fill(dt);  
//                con.Close();  
//                dataGridView1.DataSource=dt; 

