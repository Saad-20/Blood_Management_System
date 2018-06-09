using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LOGIN_L : Form
    {
        public LOGIN_L()
        {
            InitializeComponent();
            PASSWORD_T.PasswordChar = '*';
            PASSWORD_T.MaxLength = 50;

        }

        private void LOGIN_B_Click(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saad\Documents\bloodManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + USERNAME_T.Text + "'and Password ='" + PASSWORD_T.Text + "'", cons);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password");
                USERNAME_T.Text = "";
                PASSWORD_T.Text = "";
            }    
        }

        private void EXIT_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void USERNAME_T_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
