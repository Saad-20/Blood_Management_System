namespace WindowsFormsApp1
{
    partial class AvailableBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableBlood));
            this.AVAILABLE_BLOOD_L = new System.Windows.Forms.Label();
            this.AVAILABLE_BLOOD_TA = new System.Windows.Forms.DataGridView();
            this.BACK_B = new System.Windows.Forms.Button();
            this.LOAD_DATA_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AVAILABLE_BLOOD_TA)).BeginInit();
            this.SuspendLayout();
            // 
            // AVAILABLE_BLOOD_L
            // 
            this.AVAILABLE_BLOOD_L.AutoSize = true;
            this.AVAILABLE_BLOOD_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVAILABLE_BLOOD_L.Location = new System.Drawing.Point(6, -1);
            this.AVAILABLE_BLOOD_L.Name = "AVAILABLE_BLOOD_L";
            this.AVAILABLE_BLOOD_L.Size = new System.Drawing.Size(277, 31);
            this.AVAILABLE_BLOOD_L.TabIndex = 0;
            this.AVAILABLE_BLOOD_L.Text = "AVAILABLE BLOOD";
            // 
            // AVAILABLE_BLOOD_TA
            // 
            this.AVAILABLE_BLOOD_TA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AVAILABLE_BLOOD_TA.Location = new System.Drawing.Point(12, 128);
            this.AVAILABLE_BLOOD_TA.Name = "AVAILABLE_BLOOD_TA";
            this.AVAILABLE_BLOOD_TA.Size = new System.Drawing.Size(263, 198);
            this.AVAILABLE_BLOOD_TA.TabIndex = 1;
            // 
            // BACK_B
            // 
            this.BACK_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK_B.Location = new System.Drawing.Point(12, 65);
            this.BACK_B.Name = "BACK_B";
            this.BACK_B.Size = new System.Drawing.Size(120, 44);
            this.BACK_B.TabIndex = 2;
            this.BACK_B.Text = "BACK";
            this.BACK_B.UseVisualStyleBackColor = true;
            this.BACK_B.Click += new System.EventHandler(this.BACK_B_Click);
            // 
            // LOAD_DATA_B
            // 
            this.LOAD_DATA_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD_DATA_B.Location = new System.Drawing.Point(155, 65);
            this.LOAD_DATA_B.Name = "LOAD_DATA_B";
            this.LOAD_DATA_B.Size = new System.Drawing.Size(120, 44);
            this.LOAD_DATA_B.TabIndex = 3;
            this.LOAD_DATA_B.Text = "LOAD DATA";
            this.LOAD_DATA_B.UseVisualStyleBackColor = true;
            this.LOAD_DATA_B.Click += new System.EventHandler(this.LOAD_DATA_B_Click);
            // 
            // AvailableBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(285, 338);
            this.Controls.Add(this.LOAD_DATA_B);
            this.Controls.Add(this.BACK_B);
            this.Controls.Add(this.AVAILABLE_BLOOD_TA);
            this.Controls.Add(this.AVAILABLE_BLOOD_L);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AvailableBlood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifa Blood Bank";
            ((System.ComponentModel.ISupportInitialize)(this.AVAILABLE_BLOOD_TA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AVAILABLE_BLOOD_L;
        private System.Windows.Forms.DataGridView AVAILABLE_BLOOD_TA;
        private System.Windows.Forms.Button BACK_B;
        private System.Windows.Forms.Button LOAD_DATA_B;
    }
}