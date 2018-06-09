namespace WindowsFormsApp1
{
    partial class LOGIN_L
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_L));
            this.label1 = new System.Windows.Forms.Label();
            this.USERNAME_L = new System.Windows.Forms.Label();
            this.PASSWORD_L = new System.Windows.Forms.Label();
            this.USERNAME_T = new System.Windows.Forms.TextBox();
            this.PASSWORD_T = new System.Windows.Forms.TextBox();
            this.LOGIN_B = new System.Windows.Forms.Button();
            this.EXIT_B = new System.Windows.Forms.Button();
            this.DONOR_RECORD_P = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DONOR_RECORD_P)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // USERNAME_L
            // 
            this.USERNAME_L.AutoSize = true;
            this.USERNAME_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME_L.Location = new System.Drawing.Point(167, 118);
            this.USERNAME_L.Name = "USERNAME_L";
            this.USERNAME_L.Size = new System.Drawing.Size(132, 29);
            this.USERNAME_L.TabIndex = 1;
            this.USERNAME_L.Text = "Username";
            // 
            // PASSWORD_L
            // 
            this.PASSWORD_L.AutoSize = true;
            this.PASSWORD_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD_L.Location = new System.Drawing.Point(169, 164);
            this.PASSWORD_L.Name = "PASSWORD_L";
            this.PASSWORD_L.Size = new System.Drawing.Size(128, 29);
            this.PASSWORD_L.TabIndex = 3;
            this.PASSWORD_L.Text = "Password";
            // 
            // USERNAME_T
            // 
            this.USERNAME_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME_T.Location = new System.Drawing.Point(296, 118);
            this.USERNAME_T.Name = "USERNAME_T";
            this.USERNAME_T.Size = new System.Drawing.Size(255, 35);
            this.USERNAME_T.TabIndex = 4;
            this.USERNAME_T.KeyDown += new System.Windows.Forms.KeyEventHandler(this.USERNAME_T_KeyDown);
            // 
            // PASSWORD_T
            // 
            this.PASSWORD_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD_T.Location = new System.Drawing.Point(296, 164);
            this.PASSWORD_T.Name = "PASSWORD_T";
            this.PASSWORD_T.Size = new System.Drawing.Size(255, 35);
            this.PASSWORD_T.TabIndex = 5;
            // 
            // LOGIN_B
            // 
            this.LOGIN_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_B.Location = new System.Drawing.Point(428, 205);
            this.LOGIN_B.Name = "LOGIN_B";
            this.LOGIN_B.Size = new System.Drawing.Size(123, 48);
            this.LOGIN_B.TabIndex = 6;
            this.LOGIN_B.Text = "Login";
            this.LOGIN_B.UseVisualStyleBackColor = true;
            this.LOGIN_B.Click += new System.EventHandler(this.LOGIN_B_Click);
            // 
            // EXIT_B
            // 
            this.EXIT_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_B.Location = new System.Drawing.Point(296, 205);
            this.EXIT_B.Name = "EXIT_B";
            this.EXIT_B.Size = new System.Drawing.Size(117, 48);
            this.EXIT_B.TabIndex = 7;
            this.EXIT_B.Text = "Exit";
            this.EXIT_B.UseVisualStyleBackColor = true;
            this.EXIT_B.Click += new System.EventHandler(this.EXIT_B_Click);
            // 
            // DONOR_RECORD_P
            // 
            this.DONOR_RECORD_P.Image = global::WindowsFormsApp1.Properties.Resources.Blood;
            this.DONOR_RECORD_P.Location = new System.Drawing.Point(14, 99);
            this.DONOR_RECORD_P.Name = "DONOR_RECORD_P";
            this.DONOR_RECORD_P.Size = new System.Drawing.Size(129, 142);
            this.DONOR_RECORD_P.TabIndex = 8;
            this.DONOR_RECORD_P.TabStop = false;
            // 
            // LOGIN_L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(563, 285);
            this.Controls.Add(this.DONOR_RECORD_P);
            this.Controls.Add(this.EXIT_B);
            this.Controls.Add(this.LOGIN_B);
            this.Controls.Add(this.PASSWORD_T);
            this.Controls.Add(this.USERNAME_T);
            this.Controls.Add(this.PASSWORD_L);
            this.Controls.Add(this.USERNAME_L);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LOGIN_L";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifa Blood Bank";
            ((System.ComponentModel.ISupportInitialize)(this.DONOR_RECORD_P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USERNAME_L;
        private System.Windows.Forms.Label PASSWORD_L;
        private System.Windows.Forms.TextBox USERNAME_T;
        private System.Windows.Forms.TextBox PASSWORD_T;
        private System.Windows.Forms.Button LOGIN_B;
        private System.Windows.Forms.Button EXIT_B;
        private System.Windows.Forms.PictureBox DONOR_RECORD_P;
    }
}

