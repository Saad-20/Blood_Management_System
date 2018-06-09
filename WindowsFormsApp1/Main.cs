using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public bool Cancel { get; private set; }

        private void SIGN_OUT_Click(object sender, EventArgs U)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to sign out", "Sign out", MessageBoxButtons.YesNo);
           
            if(dialog == DialogResult.Yes)
            {
                this.Hide();
                LOGIN_L lOGIN = new LOGIN_L();
                lOGIN.Show();
                MessageBox.Show("Logout successful");
            }

            else if(dialog == DialogResult.No)
            {
                Cancel = true;
            }

        }

        private void DONOR_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorForm form = new DonorForm();
            form.Show();
        }

        private void DONOR_RECORD_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorRecord donorRecord = new DonorRecord();
            donorRecord.Show();
        }

        private void DONATE_BLOOD_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonateBlood blood = new DonateBlood();
            blood.Show();
        }

        private void BUYER_B_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBuyer search_Buyer = new SearchBuyer();
            search_Buyer.Show();
        }

        private void AVAILABLE_BLOOD_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableBlood available = new AvailableBlood();
            available.Show();

        }
    }
}
