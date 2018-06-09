using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class SearchBuyer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saad\Documents\bloodManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public SearchBuyer()
        {
            InitializeComponent();
        }

        private void BACK_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void SEARCH_BUYER_T_TextChanged(object sender, EventArgs e)
        {
            if(SEARCH_TYPE_C.Text == "ID")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                ("SELECT ID, First_Name, Last_Name, Cell_Number, Address, Blood_type, Date_Of_Donation FROM dbo.DONATE_BLOOD WHERE ID LIKE'"+SEARCH_BUYER_T.Text+"'",con);

                DataTable table = new DataTable();

                sqlDataAdapter.Fill(table);

                SEARCH_BUYER_TA.DataSource = table;
            }

            else if(SEARCH_TYPE_C.Text == "FIRST NAME")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                ("SELECT ID, First_Name, Last_Name, Cell_Number, Address, Blood_type, Date_Of_Donation FROM dbo.DONATE_BLOOD WHERE First_Name LIKE'" + SEARCH_BUYER_T.Text + "'", con);

                DataTable table = new DataTable();

                sqlDataAdapter.Fill(table);

                SEARCH_BUYER_TA.DataSource = table;
            }

            else if (SEARCH_TYPE_C.Text == "LAST NAME")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                ("SELECT ID, First_Name, Last_Name, Cell_Number, Address, Blood_type, Date_Of_Donation FROM dbo.DONATE_BLOOD WHERE Last_Name LIKE'" + SEARCH_BUYER_T.Text + "'", con);

                DataTable table = new DataTable();

                sqlDataAdapter.Fill(table);

                SEARCH_BUYER_TA.DataSource = table;
            }

            else if (SEARCH_TYPE_C.Text == "CELL NO")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                ("SELECT ID, First_Name, Last_Name, Cell_Number, Address, Blood_type, Date_Of_Donation FROM dbo.DONATE_BLOOD WHERE Cell_Number LIKE'" + SEARCH_BUYER_T.Text + "'", con);

                DataTable table = new DataTable();

                sqlDataAdapter.Fill(table);

                SEARCH_BUYER_TA.DataSource = table;
            }

            else if (SEARCH_TYPE_C.Text == "BLOOD TYPE")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                    ("SELECT ID, First_Name, Last_Name, Cell_Number, Address, Blood_type, Date_Of_Donation FROM dbo.DONATE_BLOOD WHERE Blood_type LIKE'" + SEARCH_BUYER_T.Text + "'", con);

                DataTable table = new DataTable();

                sqlDataAdapter.Fill(table);

                SEARCH_BUYER_TA.DataSource = table;
            }

            else if (SEARCH_TYPE_C.Text == "DATE OF DONATION")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                    ("SELECT ID, First_Name, Last_Name, Cell_Number, Address, Blood_type, Date_Of_Donation FROM dbo.DONATE_BLOOD WHERE Date_Of_Donation LIKE'" + SEARCH_BUYER_T.Text + "'", con);

                DataTable table = new DataTable();

                sqlDataAdapter.Fill(table);

                SEARCH_BUYER_TA.DataSource = table;
            }



        }

        
    }
}
