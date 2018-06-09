using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DonorRecord : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saad\Documents\bloodManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public DonorRecord()
        {
            InitializeComponent();
        }

        private void SEARCH_DONOR_T_TextChanged(object sender, EventArgs e)
        {
            if (SEARCH_TYPE_C.Text == "ID")
            {
                SqlDataAdapter adapter = new SqlDataAdapter
                    ("SELECT Id, First_Name, Last_Name, Age, Gender, Address, Marital_Status, Contact_Number, City, Blood_Type FROM dbo.DONOR_FORM WHERE Id LIKE '"+ SEARCH_DONOR_T.Text+ "'", con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                DONOR_GRID_TA.DataSource = table;
            }

           else if (SEARCH_TYPE_C.Text == "FIRST NAME")
           {
                SqlDataAdapter adapter = new SqlDataAdapter
                    ("SELECT Id, First_Name, Last_Name, Age, Gender, Address, Marital_Status, Contact_Number, City, Blood_Type FROM dbo.DONOR_FORM WHERE First_Name LIKE '" + SEARCH_DONOR_T.Text + "'", con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                DONOR_GRID_TA.DataSource = table;
           }

            else if (SEARCH_TYPE_C.Text == "LAST NAME")
            {
                SqlDataAdapter adapter = new SqlDataAdapter
                    ("SELECT Id, First_Name, Last_Name, Age, Gender, Address, Marital_Status, Contact_Number, City, Blood_Type FROM dbo.DONOR_FORM WHERE Last_Name LIKE '" + SEARCH_DONOR_T.Text + "'", con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                DONOR_GRID_TA.DataSource = table;
            }

            else if (SEARCH_TYPE_C.Text == "CITY")
            {
                SqlDataAdapter adapter = new SqlDataAdapter
                    ("SELECT Id, First_Name, Last_Name, Age, Gender, Address, Marital_Status, Contact_Number, City, Blood_Type FROM dbo.DONOR_FORM WHERE City LIKE '" + SEARCH_DONOR_T.Text + "'", con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                DONOR_GRID_TA.DataSource = table;
            }

            else if (SEARCH_TYPE_C.Text == "BLOOD TYPE")
            {
                SqlDataAdapter adapter = new SqlDataAdapter
                    ("SELECT Id, First_Name, Last_Name, Age, Gender, Address, Marital_Status, Contact_Number, City, Blood_Type FROM dbo.DONOR_FORM WHERE Blood_Type LIKE '" + SEARCH_DONOR_T.Text + "'", con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                DONOR_GRID_TA.DataSource = table;
            }

        }

        private void BACK_B_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
