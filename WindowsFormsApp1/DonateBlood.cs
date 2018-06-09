using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
        }

        private void BACK_B_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void SAVE_B_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saad\Documents\bloodManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                int Id = Convert.ToInt32(ID_T.Text.Trim());

                string first_Name = FIRST_NAME_T.Text.Trim();

                string last_Name = LAST_NAME_T.Text.Trim();

                string cell_Number = CELL_NUMBER_T.Text.Trim();

                string address = ADDRESS_T.Text.Trim();

                string blood_Type = BLOOD_TYPE_C.SelectedItem.ToString();

                string date_of_donation = DATE_OF_DONATION_TIME.Text.Trim();

                String Query = "INSERT INTO DONATE_BLOOD(ID, First_Name, Last_Name, Cell_Number, Address, Blood_type, Date_Of_Donation)VALUES(@ID, @First_Name, @Last_Name, @Cell_Number, @Address, @Blood_type, @Date_Of_Donation)";

                SqlCommand Insert = new SqlCommand(Query, con)
                {
                    Connection = con
                };

                Insert.Parameters.AddWithValue(@"ID",Id);

                Insert.Parameters.AddWithValue(@"First_Name",first_Name);

                Insert.Parameters.AddWithValue(@"Last_Name",last_Name);

                Insert.Parameters.AddWithValue(@"Cell_Number",cell_Number);

                Insert.Parameters.AddWithValue(@"Address",address);

                Insert.Parameters.AddWithValue(@"Blood_type",blood_Type);

                Insert.Parameters.AddWithValue(@"Date_Of_Donation",date_of_donation);

                Insert.ExecuteNonQuery();

                MessageBox.Show("Saved Data Successfully");

                string query = "UPDATE Available_Blood SET Amounts_of_Blood = Amounts_of_Blood - 1 WHERE Blood_Group ='"+blood_Type+"'";

                SqlCommand insert = new SqlCommand(query,con);

                insert.ExecuteNonQuery();

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Data not saved", ex.Message);
            }

        }

        private void CLEAR_B_Click(object sender, EventArgs e)
        {
            ID_T.Text = "";

            FIRST_NAME_T.Text = "";

            LAST_NAME_T.Text = "";

            CELL_NUMBER_T.Text = "";

            ADDRESS_T.Text = "";

            DATE_OF_DONATION_TIME = null;
             
        }

       
    }
}
