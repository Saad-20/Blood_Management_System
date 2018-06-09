using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class AvailableBlood : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saad\Documents\bloodManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public AvailableBlood()
        {
            InitializeComponent();
        }

        private void BACK_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void LOAD_DATA_B_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Available_Blood ", con);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            AVAILABLE_BLOOD_TA.DataSource = table;
        }
    }
}
