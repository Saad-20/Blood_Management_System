namespace WindowsFormsApp1
{
    partial class DonateBlood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonateBlood));
            this.DONATE_BLOOD_TO_L = new System.Windows.Forms.Label();
            this.ID_L = new System.Windows.Forms.Label();
            this.BLOOD_TYPE_L = new System.Windows.Forms.Label();
            this.DATE_OF_DONATION_L = new System.Windows.Forms.Label();
            this.ID_T = new System.Windows.Forms.TextBox();
            this.BACK_B = new System.Windows.Forms.Button();
            this.SAVE_B = new System.Windows.Forms.Button();
            this.DATE_OF_DONATION_TIME = new System.Windows.Forms.DateTimePicker();
            this.BLOOD_TYPE_C = new System.Windows.Forms.ComboBox();
            this.CLEAR_B = new System.Windows.Forms.Button();
            this.FIRST_NAME_T = new System.Windows.Forms.TextBox();
            this.FIRST_NAME_L = new System.Windows.Forms.Label();
            this.CELL_NUMBER_T = new System.Windows.Forms.TextBox();
            this.CELL_NO_L = new System.Windows.Forms.Label();
            this.LAST_NAME_T = new System.Windows.Forms.TextBox();
            this.LAST_NAME_L = new System.Windows.Forms.Label();
            this.ADDRESS_T = new System.Windows.Forms.TextBox();
            this.ADDRESS_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DONATE_BLOOD_TO_L
            // 
            this.DONATE_BLOOD_TO_L.AutoSize = true;
            this.DONATE_BLOOD_TO_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONATE_BLOOD_TO_L.Location = new System.Drawing.Point(59, -1);
            this.DONATE_BLOOD_TO_L.Name = "DONATE_BLOOD_TO_L";
            this.DONATE_BLOOD_TO_L.Size = new System.Drawing.Size(363, 39);
            this.DONATE_BLOOD_TO_L.TabIndex = 0;
            this.DONATE_BLOOD_TO_L.Text = "DONATE BLOOD TO";
            // 
            // ID_L
            // 
            this.ID_L.AutoSize = true;
            this.ID_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_L.Location = new System.Drawing.Point(1, 62);
            this.ID_L.Name = "ID_L";
            this.ID_L.Size = new System.Drawing.Size(29, 24);
            this.ID_L.TabIndex = 1;
            this.ID_L.Text = "ID";
            // 
            // BLOOD_TYPE_L
            // 
            this.BLOOD_TYPE_L.AutoSize = true;
            this.BLOOD_TYPE_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLOOD_TYPE_L.Location = new System.Drawing.Point(1, 269);
            this.BLOOD_TYPE_L.Name = "BLOOD_TYPE_L";
            this.BLOOD_TYPE_L.Size = new System.Drawing.Size(139, 24);
            this.BLOOD_TYPE_L.TabIndex = 5;
            this.BLOOD_TYPE_L.Text = "BLOOD TYPE";
            // 
            // DATE_OF_DONATION_L
            // 
            this.DATE_OF_DONATION_L.AutoSize = true;
            this.DATE_OF_DONATION_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_OF_DONATION_L.Location = new System.Drawing.Point(1, 306);
            this.DATE_OF_DONATION_L.Name = "DATE_OF_DONATION_L";
            this.DATE_OF_DONATION_L.Size = new System.Drawing.Size(214, 24);
            this.DATE_OF_DONATION_L.TabIndex = 7;
            this.DATE_OF_DONATION_L.Text = "DATE OF DONATION";
            // 
            // ID_T
            // 
            this.ID_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_T.Location = new System.Drawing.Point(241, 60);
            this.ID_T.Name = "ID_T";
            this.ID_T.Size = new System.Drawing.Size(212, 26);
            this.ID_T.TabIndex = 8;
            // 
            // BACK_B
            // 
            this.BACK_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK_B.Location = new System.Drawing.Point(5, 383);
            this.BACK_B.Name = "BACK_B";
            this.BACK_B.Size = new System.Drawing.Size(135, 42);
            this.BACK_B.TabIndex = 12;
            this.BACK_B.Text = "BACK";
            this.BACK_B.UseVisualStyleBackColor = true;
            this.BACK_B.Click += new System.EventHandler(this.BACK_B_Click);
            // 
            // SAVE_B
            // 
            this.SAVE_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE_B.Location = new System.Drawing.Point(318, 383);
            this.SAVE_B.Name = "SAVE_B";
            this.SAVE_B.Size = new System.Drawing.Size(135, 42);
            this.SAVE_B.TabIndex = 13;
            this.SAVE_B.Text = "SAVE";
            this.SAVE_B.UseVisualStyleBackColor = true;
            this.SAVE_B.Click += new System.EventHandler(this.SAVE_B_Click);
            // 
            // DATE_OF_DONATION_TIME
            // 
            this.DATE_OF_DONATION_TIME.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_OF_DONATION_TIME.CustomFormat = "yyyy-MM-dd";
            this.DATE_OF_DONATION_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DATE_OF_DONATION_TIME.Location = new System.Drawing.Point(241, 308);
            this.DATE_OF_DONATION_TIME.Name = "DATE_OF_DONATION_TIME";
            this.DATE_OF_DONATION_TIME.Size = new System.Drawing.Size(91, 20);
            this.DATE_OF_DONATION_TIME.TabIndex = 14;
            // 
            // BLOOD_TYPE_C
            // 
            this.BLOOD_TYPE_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLOOD_TYPE_C.FormattingEnabled = true;
            this.BLOOD_TYPE_C.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BLOOD_TYPE_C.Location = new System.Drawing.Point(241, 267);
            this.BLOOD_TYPE_C.Name = "BLOOD_TYPE_C";
            this.BLOOD_TYPE_C.Size = new System.Drawing.Size(91, 26);
            this.BLOOD_TYPE_C.TabIndex = 15;
            // 
            // CLEAR_B
            // 
            this.CLEAR_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_B.Location = new System.Drawing.Point(164, 383);
            this.CLEAR_B.Name = "CLEAR_B";
            this.CLEAR_B.Size = new System.Drawing.Size(135, 42);
            this.CLEAR_B.TabIndex = 17;
            this.CLEAR_B.Text = "CLEAR";
            this.CLEAR_B.UseVisualStyleBackColor = true;
            this.CLEAR_B.Click += new System.EventHandler(this.CLEAR_B_Click);
            // 
            // FIRST_NAME_T
            // 
            this.FIRST_NAME_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRST_NAME_T.Location = new System.Drawing.Point(241, 102);
            this.FIRST_NAME_T.Name = "FIRST_NAME_T";
            this.FIRST_NAME_T.Size = new System.Drawing.Size(212, 26);
            this.FIRST_NAME_T.TabIndex = 19;
            // 
            // FIRST_NAME_L
            // 
            this.FIRST_NAME_L.AutoSize = true;
            this.FIRST_NAME_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRST_NAME_L.Location = new System.Drawing.Point(1, 104);
            this.FIRST_NAME_L.Name = "FIRST_NAME_L";
            this.FIRST_NAME_L.Size = new System.Drawing.Size(134, 24);
            this.FIRST_NAME_L.TabIndex = 18;
            this.FIRST_NAME_L.Text = "FIRST NAME";
            // 
            // CELL_NUMBER_T
            // 
            this.CELL_NUMBER_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CELL_NUMBER_T.Location = new System.Drawing.Point(241, 185);
            this.CELL_NUMBER_T.Name = "CELL_NUMBER_T";
            this.CELL_NUMBER_T.Size = new System.Drawing.Size(212, 26);
            this.CELL_NUMBER_T.TabIndex = 23;
            // 
            // CELL_NO_L
            // 
            this.CELL_NO_L.AutoSize = true;
            this.CELL_NO_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CELL_NO_L.Location = new System.Drawing.Point(1, 187);
            this.CELL_NO_L.Name = "CELL_NO_L";
            this.CELL_NO_L.Size = new System.Drawing.Size(153, 24);
            this.CELL_NO_L.TabIndex = 22;
            this.CELL_NO_L.Text = "CELL NUMBER";
            // 
            // LAST_NAME_T
            // 
            this.LAST_NAME_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAST_NAME_T.Location = new System.Drawing.Point(241, 143);
            this.LAST_NAME_T.Name = "LAST_NAME_T";
            this.LAST_NAME_T.Size = new System.Drawing.Size(212, 26);
            this.LAST_NAME_T.TabIndex = 21;
            // 
            // LAST_NAME_L
            // 
            this.LAST_NAME_L.AutoSize = true;
            this.LAST_NAME_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAST_NAME_L.Location = new System.Drawing.Point(1, 145);
            this.LAST_NAME_L.Name = "LAST_NAME_L";
            this.LAST_NAME_L.Size = new System.Drawing.Size(127, 24);
            this.LAST_NAME_L.TabIndex = 20;
            this.LAST_NAME_L.Text = "LAST NAME";
            // 
            // ADDRESS_T
            // 
            this.ADDRESS_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDRESS_T.Location = new System.Drawing.Point(241, 227);
            this.ADDRESS_T.Name = "ADDRESS_T";
            this.ADDRESS_T.Size = new System.Drawing.Size(212, 26);
            this.ADDRESS_T.TabIndex = 25;
            // 
            // ADDRESS_L
            // 
            this.ADDRESS_L.AutoSize = true;
            this.ADDRESS_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDRESS_L.Location = new System.Drawing.Point(1, 229);
            this.ADDRESS_L.Name = "ADDRESS_L";
            this.ADDRESS_L.Size = new System.Drawing.Size(106, 24);
            this.ADDRESS_L.TabIndex = 24;
            this.ADDRESS_L.Text = "ADDRESS";
            // 
            // DonateBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(469, 441);
            this.Controls.Add(this.ADDRESS_T);
            this.Controls.Add(this.ADDRESS_L);
            this.Controls.Add(this.CELL_NUMBER_T);
            this.Controls.Add(this.CELL_NO_L);
            this.Controls.Add(this.LAST_NAME_T);
            this.Controls.Add(this.LAST_NAME_L);
            this.Controls.Add(this.FIRST_NAME_T);
            this.Controls.Add(this.FIRST_NAME_L);
            this.Controls.Add(this.CLEAR_B);
            this.Controls.Add(this.BLOOD_TYPE_C);
            this.Controls.Add(this.DATE_OF_DONATION_TIME);
            this.Controls.Add(this.SAVE_B);
            this.Controls.Add(this.BACK_B);
            this.Controls.Add(this.ID_T);
            this.Controls.Add(this.DATE_OF_DONATION_L);
            this.Controls.Add(this.BLOOD_TYPE_L);
            this.Controls.Add(this.ID_L);
            this.Controls.Add(this.DONATE_BLOOD_TO_L);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DonateBlood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifa Blood Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DONATE_BLOOD_TO_L;
        private System.Windows.Forms.Label ID_L;
        private System.Windows.Forms.Label BLOOD_TYPE_L;
        private System.Windows.Forms.Label DATE_OF_DONATION_L;
        private System.Windows.Forms.TextBox ID_T;
        private System.Windows.Forms.Button BACK_B;
        private System.Windows.Forms.Button SAVE_B;
        private System.Windows.Forms.DateTimePicker DATE_OF_DONATION_TIME;
        private System.Windows.Forms.ComboBox BLOOD_TYPE_C;
        private System.Windows.Forms.Button CLEAR_B;
        private System.Windows.Forms.TextBox FIRST_NAME_T;
        private System.Windows.Forms.Label FIRST_NAME_L;
        private System.Windows.Forms.TextBox CELL_NUMBER_T;
        private System.Windows.Forms.Label CELL_NO_L;
        private System.Windows.Forms.TextBox LAST_NAME_T;
        private System.Windows.Forms.Label LAST_NAME_L;
        private System.Windows.Forms.TextBox ADDRESS_T;
        private System.Windows.Forms.Label ADDRESS_L;
    }
}