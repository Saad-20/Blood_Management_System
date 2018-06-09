namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DONOR_B = new System.Windows.Forms.Button();
            this.DONATE_BLOOD_B = new System.Windows.Forms.Button();
            this.DONOR_RECORD_B = new System.Windows.Forms.Button();
            this.BUYER_B = new System.Windows.Forms.Button();
            this.AVAILABLE_BLOOD = new System.Windows.Forms.Button();
            this.SIGN_OUT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DONOR_B
            // 
            this.DONOR_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONOR_B.Location = new System.Drawing.Point(36, 55);
            this.DONOR_B.Name = "DONOR_B";
            this.DONOR_B.Size = new System.Drawing.Size(246, 34);
            this.DONOR_B.TabIndex = 0;
            this.DONOR_B.Text = "DONOR FORM";
            this.DONOR_B.UseVisualStyleBackColor = true;
            this.DONOR_B.Click += new System.EventHandler(this.DONOR_B_Click);
            // 
            // DONATE_BLOOD_B
            // 
            this.DONATE_BLOOD_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONATE_BLOOD_B.Location = new System.Drawing.Point(36, 155);
            this.DONATE_BLOOD_B.Name = "DONATE_BLOOD_B";
            this.DONATE_BLOOD_B.Size = new System.Drawing.Size(246, 34);
            this.DONATE_BLOOD_B.TabIndex = 3;
            this.DONATE_BLOOD_B.Text = "DONATE BLOOD TO";
            this.DONATE_BLOOD_B.UseVisualStyleBackColor = true;
            this.DONATE_BLOOD_B.Click += new System.EventHandler(this.DONATE_BLOOD_B_Click);
            // 
            // DONOR_RECORD_B
            // 
            this.DONOR_RECORD_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONOR_RECORD_B.Location = new System.Drawing.Point(36, 104);
            this.DONOR_RECORD_B.Name = "DONOR_RECORD_B";
            this.DONOR_RECORD_B.Size = new System.Drawing.Size(246, 34);
            this.DONOR_RECORD_B.TabIndex = 1;
            this.DONOR_RECORD_B.Text = "DONOR RECORD";
            this.DONOR_RECORD_B.UseVisualStyleBackColor = true;
            this.DONOR_RECORD_B.Click += new System.EventHandler(this.DONOR_RECORD_B_Click);
            // 
            // BUYER_B
            // 
            this.BUYER_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUYER_B.Location = new System.Drawing.Point(36, 204);
            this.BUYER_B.Name = "BUYER_B";
            this.BUYER_B.Size = new System.Drawing.Size(246, 34);
            this.BUYER_B.TabIndex = 4;
            this.BUYER_B.Text = "SEARCH BUYER";
            this.BUYER_B.UseVisualStyleBackColor = true;
            this.BUYER_B.Click += new System.EventHandler(this.BUYER_B_Click);
            // 
            // AVAILABLE_BLOOD
            // 
            this.AVAILABLE_BLOOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVAILABLE_BLOOD.Location = new System.Drawing.Point(36, 255);
            this.AVAILABLE_BLOOD.Name = "AVAILABLE_BLOOD";
            this.AVAILABLE_BLOOD.Size = new System.Drawing.Size(246, 34);
            this.AVAILABLE_BLOOD.TabIndex = 5;
            this.AVAILABLE_BLOOD.Text = "PACKETS OF BLOOD";
            this.AVAILABLE_BLOOD.UseVisualStyleBackColor = true;
            this.AVAILABLE_BLOOD.Click += new System.EventHandler(this.AVAILABLE_BLOOD_Click);
            // 
            // SIGN_OUT
            // 
            this.SIGN_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGN_OUT.Location = new System.Drawing.Point(96, 308);
            this.SIGN_OUT.Name = "SIGN_OUT";
            this.SIGN_OUT.Size = new System.Drawing.Size(121, 47);
            this.SIGN_OUT.TabIndex = 6;
            this.SIGN_OUT.Text = "SIGN OUT";
            this.SIGN_OUT.UseVisualStyleBackColor = true;
            this.SIGN_OUT.Click += new System.EventHandler(this.SIGN_OUT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "SELECTION FORM";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(316, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AVAILABLE_BLOOD);
            this.Controls.Add(this.SIGN_OUT);
            this.Controls.Add(this.BUYER_B);
            this.Controls.Add(this.DONOR_RECORD_B);
            this.Controls.Add(this.DONATE_BLOOD_B);
            this.Controls.Add(this.DONOR_B);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifa Blood Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DONOR_B;
        private System.Windows.Forms.Button DONATE_BLOOD_B;
        private System.Windows.Forms.Button DONOR_RECORD_B;
        private System.Windows.Forms.Button BUYER_B;
        private System.Windows.Forms.Button AVAILABLE_BLOOD;
        private System.Windows.Forms.Button SIGN_OUT;
        private System.Windows.Forms.Label label1;
    }
}