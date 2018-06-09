namespace WindowsFormsApp1
{
    partial class DonorRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorRecord));
            this.DONOR_RECORD_L = new System.Windows.Forms.Label();
            this.DONOR_GRID_TA = new System.Windows.Forms.DataGridView();
            this.SEARCH_TYPE_C = new System.Windows.Forms.ComboBox();
            this.SEARCH_DONOR_T = new System.Windows.Forms.TextBox();
            this.SEARCH_TYPE_L = new System.Windows.Forms.Label();
            this.SEARCH_DON0R_L = new System.Windows.Forms.Label();
            this.BACK_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DONOR_GRID_TA)).BeginInit();
            this.SuspendLayout();
            // 
            // DONOR_RECORD_L
            // 
            this.DONOR_RECORD_L.AutoSize = true;
            this.DONOR_RECORD_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONOR_RECORD_L.Location = new System.Drawing.Point(349, 0);
            this.DONOR_RECORD_L.Name = "DONOR_RECORD_L";
            this.DONOR_RECORD_L.Size = new System.Drawing.Size(317, 39);
            this.DONOR_RECORD_L.TabIndex = 0;
            this.DONOR_RECORD_L.Text = "DONOR RECORD";
            // 
            // DONOR_GRID_TA
            // 
            this.DONOR_GRID_TA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DONOR_GRID_TA.Location = new System.Drawing.Point(12, 135);
            this.DONOR_GRID_TA.Name = "DONOR_GRID_TA";
            this.DONOR_GRID_TA.Size = new System.Drawing.Size(1037, 351);
            this.DONOR_GRID_TA.TabIndex = 1;
            // 
            // SEARCH_TYPE_C
            // 
            this.SEARCH_TYPE_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_TYPE_C.FormattingEnabled = true;
            this.SEARCH_TYPE_C.Items.AddRange(new object[] {
            "ID",
            "FIRST NAME",
            "LAST NAME",
            "CITY",
            "BLOOD TYPE"});
            this.SEARCH_TYPE_C.Location = new System.Drawing.Point(190, 87);
            this.SEARCH_TYPE_C.Name = "SEARCH_TYPE_C";
            this.SEARCH_TYPE_C.Size = new System.Drawing.Size(144, 26);
            this.SEARCH_TYPE_C.TabIndex = 2;
            // 
            // SEARCH_DONOR_T
            // 
            this.SEARCH_DONOR_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_DONOR_T.Location = new System.Drawing.Point(551, 86);
            this.SEARCH_DONOR_T.Name = "SEARCH_DONOR_T";
            this.SEARCH_DONOR_T.Size = new System.Drawing.Size(200, 26);
            this.SEARCH_DONOR_T.TabIndex = 3;
            this.SEARCH_DONOR_T.TextChanged += new System.EventHandler(this.SEARCH_DONOR_T_TextChanged);
            // 
            // SEARCH_TYPE_L
            // 
            this.SEARCH_TYPE_L.AutoSize = true;
            this.SEARCH_TYPE_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_TYPE_L.Location = new System.Drawing.Point(12, 88);
            this.SEARCH_TYPE_L.Name = "SEARCH_TYPE_L";
            this.SEARCH_TYPE_L.Size = new System.Drawing.Size(172, 25);
            this.SEARCH_TYPE_L.TabIndex = 4;
            this.SEARCH_TYPE_L.Text = "SEARCH TYPE";
            // 
            // SEARCH_DON0R_L
            // 
            this.SEARCH_DON0R_L.AutoSize = true;
            this.SEARCH_DON0R_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_DON0R_L.Location = new System.Drawing.Point(351, 88);
            this.SEARCH_DON0R_L.Name = "SEARCH_DON0R_L";
            this.SEARCH_DON0R_L.Size = new System.Drawing.Size(194, 25);
            this.SEARCH_DON0R_L.TabIndex = 5;
            this.SEARCH_DON0R_L.Text = "SEARCH DONOR";
            // 
            // BACK_B
            // 
            this.BACK_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK_B.Location = new System.Drawing.Point(805, 79);
            this.BACK_B.Name = "BACK_B";
            this.BACK_B.Size = new System.Drawing.Size(131, 36);
            this.BACK_B.TabIndex = 6;
            this.BACK_B.Text = "BACK";
            this.BACK_B.UseVisualStyleBackColor = true;
            this.BACK_B.Click += new System.EventHandler(this.BACK_B_Click);
            // 
            // DonorRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1061, 498);
            this.Controls.Add(this.BACK_B);
            this.Controls.Add(this.SEARCH_DON0R_L);
            this.Controls.Add(this.SEARCH_TYPE_L);
            this.Controls.Add(this.SEARCH_DONOR_T);
            this.Controls.Add(this.SEARCH_TYPE_C);
            this.Controls.Add(this.DONOR_GRID_TA);
            this.Controls.Add(this.DONOR_RECORD_L);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DonorRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifa Blood Bank";
            ((System.ComponentModel.ISupportInitialize)(this.DONOR_GRID_TA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DONOR_RECORD_L;
        private System.Windows.Forms.DataGridView DONOR_GRID_TA;
        private System.Windows.Forms.ComboBox SEARCH_TYPE_C;
        private System.Windows.Forms.TextBox SEARCH_DONOR_T;
        private System.Windows.Forms.Label SEARCH_TYPE_L;
        private System.Windows.Forms.Label SEARCH_DON0R_L;
        private System.Windows.Forms.Button BACK_B;
    }
}