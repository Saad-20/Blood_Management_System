namespace WindowsFormsApp1
{
    partial class DonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorForm));
            this.DONOR_FORM_L = new System.Windows.Forms.Label();
            this.DONOR_ID_L = new System.Windows.Forms.Label();
            this.DONOR_ID_T = new System.Windows.Forms.TextBox();
            this.LAST_NAME_T = new System.Windows.Forms.TextBox();
            this.LAST_NAME_L = new System.Windows.Forms.Label();
            this.FIRST_NAME_T = new System.Windows.Forms.TextBox();
            this.FIRST_NAME_L = new System.Windows.Forms.Label();
            this.GENDER_L = new System.Windows.Forms.Label();
            this.ADDRESS_T = new System.Windows.Forms.TextBox();
            this.ADDRESS_L = new System.Windows.Forms.Label();
            this.AGE_T = new System.Windows.Forms.TextBox();
            this.AGE_L = new System.Windows.Forms.Label();
            this.BLOOD_TYPE_L = new System.Windows.Forms.Label();
            this.CITY_T = new System.Windows.Forms.TextBox();
            this.CITY_L = new System.Windows.Forms.Label();
            this.CONTACT_NO_L = new System.Windows.Forms.Label();
            this.MARITAL_STATUS_L = new System.Windows.Forms.Label();
            this.BACK_B = new System.Windows.Forms.Button();
            this.SAVE_B = new System.Windows.Forms.Button();
            this.BLOOD_TYPE_C = new System.Windows.Forms.ComboBox();
            this.CONTACT_NO_T = new System.Windows.Forms.TextBox();
            this.MALE_B = new System.Windows.Forms.RadioButton();
            this.FEMALE_B = new System.Windows.Forms.RadioButton();
            this.MARITAL_STATUS_C = new System.Windows.Forms.ComboBox();
            this.CLEAR_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DONOR_FORM_L
            // 
            this.DONOR_FORM_L.AutoSize = true;
            this.DONOR_FORM_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONOR_FORM_L.Location = new System.Drawing.Point(155, 0);
            this.DONOR_FORM_L.Name = "DONOR_FORM_L";
            this.DONOR_FORM_L.Size = new System.Drawing.Size(248, 37);
            this.DONOR_FORM_L.TabIndex = 0;
            this.DONOR_FORM_L.Text = "DONOR FORM";
            // 
            // DONOR_ID_L
            // 
            this.DONOR_ID_L.AutoSize = true;
            this.DONOR_ID_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONOR_ID_L.Location = new System.Drawing.Point(1, 77);
            this.DONOR_ID_L.Name = "DONOR_ID_L";
            this.DONOR_ID_L.Size = new System.Drawing.Size(123, 25);
            this.DONOR_ID_L.TabIndex = 1;
            this.DONOR_ID_L.Text = "DONOR ID";
            // 
            // DONOR_ID_T
            // 
            this.DONOR_ID_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONOR_ID_T.Location = new System.Drawing.Point(204, 76);
            this.DONOR_ID_T.Name = "DONOR_ID_T";
            this.DONOR_ID_T.Size = new System.Drawing.Size(255, 26);
            this.DONOR_ID_T.TabIndex = 2;
            // 
            // LAST_NAME_T
            // 
            this.LAST_NAME_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAST_NAME_T.Location = new System.Drawing.Point(204, 158);
            this.LAST_NAME_T.Name = "LAST_NAME_T";
            this.LAST_NAME_T.Size = new System.Drawing.Size(255, 26);
            this.LAST_NAME_T.TabIndex = 4;
            // 
            // LAST_NAME_L
            // 
            this.LAST_NAME_L.AutoSize = true;
            this.LAST_NAME_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAST_NAME_L.Location = new System.Drawing.Point(1, 159);
            this.LAST_NAME_L.Name = "LAST_NAME_L";
            this.LAST_NAME_L.Size = new System.Drawing.Size(141, 25);
            this.LAST_NAME_L.TabIndex = 3;
            this.LAST_NAME_L.Text = "LAST NAME";
            // 
            // FIRST_NAME_T
            // 
            this.FIRST_NAME_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRST_NAME_T.Location = new System.Drawing.Point(204, 117);
            this.FIRST_NAME_T.Name = "FIRST_NAME_T";
            this.FIRST_NAME_T.Size = new System.Drawing.Size(255, 26);
            this.FIRST_NAME_T.TabIndex = 6;
            // 
            // FIRST_NAME_L
            // 
            this.FIRST_NAME_L.AutoSize = true;
            this.FIRST_NAME_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRST_NAME_L.Location = new System.Drawing.Point(1, 118);
            this.FIRST_NAME_L.Name = "FIRST_NAME_L";
            this.FIRST_NAME_L.Size = new System.Drawing.Size(149, 25);
            this.FIRST_NAME_L.TabIndex = 5;
            this.FIRST_NAME_L.Text = "FIRST NAME";
            // 
            // GENDER_L
            // 
            this.GENDER_L.AutoSize = true;
            this.GENDER_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDER_L.Location = new System.Drawing.Point(1, 242);
            this.GENDER_L.Name = "GENDER_L";
            this.GENDER_L.Size = new System.Drawing.Size(107, 25);
            this.GENDER_L.TabIndex = 11;
            this.GENDER_L.Text = "GENDER";
            // 
            // ADDRESS_T
            // 
            this.ADDRESS_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDRESS_T.Location = new System.Drawing.Point(204, 284);
            this.ADDRESS_T.Name = "ADDRESS_T";
            this.ADDRESS_T.Size = new System.Drawing.Size(255, 26);
            this.ADDRESS_T.TabIndex = 10;
            // 
            // ADDRESS_L
            // 
            this.ADDRESS_L.AutoSize = true;
            this.ADDRESS_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDRESS_L.Location = new System.Drawing.Point(1, 283);
            this.ADDRESS_L.Name = "ADDRESS_L";
            this.ADDRESS_L.Size = new System.Drawing.Size(120, 25);
            this.ADDRESS_L.TabIndex = 9;
            this.ADDRESS_L.Text = "ADDRESS";
            // 
            // AGE_T
            // 
            this.AGE_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE_T.Location = new System.Drawing.Point(204, 200);
            this.AGE_T.Name = "AGE_T";
            this.AGE_T.Size = new System.Drawing.Size(255, 26);
            this.AGE_T.TabIndex = 8;
            // 
            // AGE_L
            // 
            this.AGE_L.AutoSize = true;
            this.AGE_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE_L.Location = new System.Drawing.Point(1, 201);
            this.AGE_L.Name = "AGE_L";
            this.AGE_L.Size = new System.Drawing.Size(59, 25);
            this.AGE_L.TabIndex = 7;
            this.AGE_L.Text = "AGE";
            // 
            // BLOOD_TYPE_L
            // 
            this.BLOOD_TYPE_L.AutoSize = true;
            this.BLOOD_TYPE_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLOOD_TYPE_L.Location = new System.Drawing.Point(1, 446);
            this.BLOOD_TYPE_L.Name = "BLOOD_TYPE_L";
            this.BLOOD_TYPE_L.Size = new System.Drawing.Size(157, 25);
            this.BLOOD_TYPE_L.TabIndex = 23;
            this.BLOOD_TYPE_L.Text = "BLOOD TYPE";
            // 
            // CITY_T
            // 
            this.CITY_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CITY_T.Location = new System.Drawing.Point(204, 404);
            this.CITY_T.Name = "CITY_T";
            this.CITY_T.Size = new System.Drawing.Size(255, 26);
            this.CITY_T.TabIndex = 20;
            // 
            // CITY_L
            // 
            this.CITY_L.AutoSize = true;
            this.CITY_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CITY_L.Location = new System.Drawing.Point(1, 405);
            this.CITY_L.Name = "CITY_L";
            this.CITY_L.Size = new System.Drawing.Size(64, 25);
            this.CITY_L.TabIndex = 19;
            this.CITY_L.Text = "CITY";
            // 
            // CONTACT_NO_L
            // 
            this.CONTACT_NO_L.AutoSize = true;
            this.CONTACT_NO_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTACT_NO_L.Location = new System.Drawing.Point(-2, 361);
            this.CONTACT_NO_L.Name = "CONTACT_NO_L";
            this.CONTACT_NO_L.Size = new System.Drawing.Size(160, 25);
            this.CONTACT_NO_L.TabIndex = 15;
            this.CONTACT_NO_L.Text = "CONTACT NO";
            // 
            // MARITAL_STATUS_L
            // 
            this.MARITAL_STATUS_L.AutoSize = true;
            this.MARITAL_STATUS_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MARITAL_STATUS_L.Location = new System.Drawing.Point(1, 325);
            this.MARITAL_STATUS_L.Name = "MARITAL_STATUS_L";
            this.MARITAL_STATUS_L.Size = new System.Drawing.Size(206, 25);
            this.MARITAL_STATUS_L.TabIndex = 13;
            this.MARITAL_STATUS_L.Text = "MARITAL STATUS";
            // 
            // BACK_B
            // 
            this.BACK_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK_B.Location = new System.Drawing.Point(6, 501);
            this.BACK_B.Name = "BACK_B";
            this.BACK_B.Size = new System.Drawing.Size(132, 41);
            this.BACK_B.TabIndex = 25;
            this.BACK_B.Text = "BACK";
            this.BACK_B.UseVisualStyleBackColor = true;
            this.BACK_B.Click += new System.EventHandler(this.BACK_B_Click);
            // 
            // SAVE_B
            // 
            this.SAVE_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE_B.Location = new System.Drawing.Point(211, 500);
            this.SAVE_B.Name = "SAVE_B";
            this.SAVE_B.Size = new System.Drawing.Size(132, 41);
            this.SAVE_B.TabIndex = 26;
            this.SAVE_B.Text = "SAVE";
            this.SAVE_B.UseVisualStyleBackColor = true;
            this.SAVE_B.Click += new System.EventHandler(this.SAVE_B_Click);
            // 
            // BLOOD_TYPE_C
            // 
            this.BLOOD_TYPE_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BLOOD_TYPE_C.Location = new System.Drawing.Point(204, 443);
            this.BLOOD_TYPE_C.Name = "BLOOD_TYPE_C";
            this.BLOOD_TYPE_C.Size = new System.Drawing.Size(139, 28);
            this.BLOOD_TYPE_C.TabIndex = 34;
            // 
            // CONTACT_NO_T
            // 
            this.CONTACT_NO_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTACT_NO_T.Location = new System.Drawing.Point(204, 362);
            this.CONTACT_NO_T.Name = "CONTACT_NO_T";
            this.CONTACT_NO_T.Size = new System.Drawing.Size(255, 26);
            this.CONTACT_NO_T.TabIndex = 35;
            // 
            // MALE_B
            // 
            this.MALE_B.AutoSize = true;
            this.MALE_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MALE_B.Location = new System.Drawing.Point(204, 244);
            this.MALE_B.Name = "MALE_B";
            this.MALE_B.Size = new System.Drawing.Size(75, 24);
            this.MALE_B.TabIndex = 36;
            this.MALE_B.TabStop = true;
            this.MALE_B.Text = "MALE";
            this.MALE_B.UseVisualStyleBackColor = true;
            // 
            // FEMALE_B
            // 
            this.FEMALE_B.AutoSize = true;
            this.FEMALE_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEMALE_B.Location = new System.Drawing.Point(327, 244);
            this.FEMALE_B.Name = "FEMALE_B";
            this.FEMALE_B.Size = new System.Drawing.Size(98, 24);
            this.FEMALE_B.TabIndex = 37;
            this.FEMALE_B.TabStop = true;
            this.FEMALE_B.Text = "FEMALE";
            this.FEMALE_B.UseVisualStyleBackColor = true;
            // 
            // MARITAL_STATUS_C
            // 
            this.MARITAL_STATUS_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MARITAL_STATUS_C.FormattingEnabled = true;
            this.MARITAL_STATUS_C.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorce",
            "Widow"});
            this.MARITAL_STATUS_C.Location = new System.Drawing.Point(204, 322);
            this.MARITAL_STATUS_C.Name = "MARITAL_STATUS_C";
            this.MARITAL_STATUS_C.Size = new System.Drawing.Size(130, 28);
            this.MARITAL_STATUS_C.TabIndex = 38;
            // 
            // CLEAR_B
            // 
            this.CLEAR_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_B.Location = new System.Drawing.Point(411, 500);
            this.CLEAR_B.Name = "CLEAR_B";
            this.CLEAR_B.Size = new System.Drawing.Size(132, 41);
            this.CLEAR_B.TabIndex = 39;
            this.CLEAR_B.Text = "CLEAR";
            this.CLEAR_B.UseVisualStyleBackColor = true;
            this.CLEAR_B.Click += new System.EventHandler(this.CLEAR_B_Click);
            // 
            // DonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(555, 553);
            this.Controls.Add(this.CLEAR_B);
            this.Controls.Add(this.MARITAL_STATUS_C);
            this.Controls.Add(this.FEMALE_B);
            this.Controls.Add(this.MALE_B);
            this.Controls.Add(this.CONTACT_NO_T);
            this.Controls.Add(this.BLOOD_TYPE_C);
            this.Controls.Add(this.SAVE_B);
            this.Controls.Add(this.BACK_B);
            this.Controls.Add(this.BLOOD_TYPE_L);
            this.Controls.Add(this.CITY_T);
            this.Controls.Add(this.CITY_L);
            this.Controls.Add(this.CONTACT_NO_L);
            this.Controls.Add(this.MARITAL_STATUS_L);
            this.Controls.Add(this.GENDER_L);
            this.Controls.Add(this.ADDRESS_T);
            this.Controls.Add(this.ADDRESS_L);
            this.Controls.Add(this.AGE_T);
            this.Controls.Add(this.AGE_L);
            this.Controls.Add(this.FIRST_NAME_T);
            this.Controls.Add(this.FIRST_NAME_L);
            this.Controls.Add(this.LAST_NAME_T);
            this.Controls.Add(this.LAST_NAME_L);
            this.Controls.Add(this.DONOR_ID_T);
            this.Controls.Add(this.DONOR_ID_L);
            this.Controls.Add(this.DONOR_FORM_L);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifa Blood Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DONOR_FORM_L;
        private System.Windows.Forms.Label DONOR_ID_L;
        private System.Windows.Forms.TextBox DONOR_ID_T;
        private System.Windows.Forms.TextBox LAST_NAME_T;
        private System.Windows.Forms.Label LAST_NAME_L;
        private System.Windows.Forms.TextBox FIRST_NAME_T;
        private System.Windows.Forms.Label FIRST_NAME_L;
        private System.Windows.Forms.Label GENDER_L;
        private System.Windows.Forms.TextBox ADDRESS_T;
        private System.Windows.Forms.Label ADDRESS_L;
        private System.Windows.Forms.TextBox AGE_T;
        private System.Windows.Forms.Label AGE_L;
        private System.Windows.Forms.Label BLOOD_TYPE_L;
        private System.Windows.Forms.TextBox CITY_T;
        private System.Windows.Forms.Label CITY_L;
        private System.Windows.Forms.Label CONTACT_NO_L;
        private System.Windows.Forms.Label MARITAL_STATUS_L;
        private System.Windows.Forms.Button BACK_B;
        private System.Windows.Forms.Button SAVE_B;
        private System.Windows.Forms.ComboBox BLOOD_TYPE_C;
        private System.Windows.Forms.TextBox CONTACT_NO_T;
        private System.Windows.Forms.RadioButton MALE_B;
        private System.Windows.Forms.RadioButton FEMALE_B;
        private System.Windows.Forms.ComboBox MARITAL_STATUS_C;
        private System.Windows.Forms.Button CLEAR_B;
    }
}