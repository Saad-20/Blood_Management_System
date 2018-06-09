using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class DonorForm : Form
    {
        string gender;
        

        public DonorForm()
        {
            InitializeComponent();
        }

        private void BACK_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

       

        private void SAVE_B_Click(object sender, EventArgs e)
        {
            try
            {
               

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saad\Documents\bloodManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                int donor_Id = Convert.ToInt32(DONOR_ID_T.Text.Trim());

                string first_Name = FIRST_NAME_T.Text.Trim();

                string last_Name = LAST_NAME_T.Text.Trim();

                int age = Convert.ToInt16(AGE_T.Text.Trim());

                if (MALE_B.Checked)
                {
                    gender = "Male";
                }

                if(FEMALE_B.Checked)
                {
                    gender = "Female";
                }

                string address = ADDRESS_T.Text.Trim();

                string contact_Number =  CONTACT_NO_T.Text.Trim();

                string city = CITY_T.Text.Trim();

                string blood_Type = BLOOD_TYPE_C.SelectedItem.ToString();

                string marital_Status = MARITAL_STATUS_C.SelectedItem.ToString();

                string Query = "INSERT INTO DONOR_FORM(Id, First_Name, Last_Name, Age, Gender, Address, Marital_Status, Contact_Number, City, Blood_Type)VALUES(@Id, @First_Name, @Last_Name, @Age, @Gender, @Address, @Marital_Status, @Contact_Number, @City, @Blood_Type)";

                SqlCommand insert = new SqlCommand(Query, con)
                {
                    Connection = con
                };

                insert.Parameters.AddWithValue(@"Id",donor_Id);

                insert.Parameters.AddWithValue(@"First_Name", first_Name);

                insert.Parameters.AddWithValue(@"Last_Name", last_Name);

                insert.Parameters.AddWithValue(@"Age", age);

                insert.Parameters.AddWithValue(@"Gender",gender);

                insert.Parameters.AddWithValue(@"Address", address);

                insert.Parameters.AddWithValue(@"Marital_Status",marital_Status);

                insert.Parameters.AddWithValue(@"Contact_Number", contact_Number);

                insert.Parameters.AddWithValue(@"City",city);

                insert.Parameters.AddWithValue(@"Blood_Type", blood_Type);

                insert.ExecuteNonQuery();

                MessageBox.Show("Saved Data Successfully");

                string query = "UPDATE Available_Blood SET Amounts_of_Blood = Amounts_of_Blood + 1 WHERE Blood_Group ='" +blood_Type+ "'";

                SqlCommand Insert = new SqlCommand(query, con);

                Insert.ExecuteNonQuery();

                con.Close();

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CLEAR_B_Click(object sender, EventArgs e)
        {
            DONOR_ID_T.Text = "";

            FIRST_NAME_T.Text = "";

            LAST_NAME_T.Text = "";

            AGE_T.Text = "";

            if(MALE_B.Checked)
            {

                MALE_B.Checked = false;

            }

            if(FEMALE_B.Checked)
            {

                FEMALE_B.Checked = false;

            }

            ADDRESS_T.Text = "";

            MARITAL_STATUS_C.SelectedItem = null;

            CONTACT_NO_T.Text = "";

            CITY_T.Text = "";

            BLOOD_TYPE_C.SelectedItem = null;

        }
    }
}
