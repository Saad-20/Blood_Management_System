namespace WindowsFormsApp1
{
    partial class SearchBuyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBuyer));
            this.SEARCH_BUYER_L = new System.Windows.Forms.Label();
            this.SEARCH_TYPE_L = new System.Windows.Forms.Label();
            this.L_SEARCH_BUYER = new System.Windows.Forms.Label();
            this.SEARCH_BUYER_T = new System.Windows.Forms.TextBox();
            this.SEARCH_TYPE_C = new System.Windows.Forms.ComboBox();
            this.BACK_B = new System.Windows.Forms.Button();
            this.SEARCH_BUYER_TA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_BUYER_TA)).BeginInit();
            this.SuspendLayout();
            // 
            // SEARCH_BUYER_L
            // 
            this.SEARCH_BUYER_L.AutoSize = true;
            this.SEARCH_BUYER_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_BUYER_L.Location = new System.Drawing.Point(280, 0);
            this.SEARCH_BUYER_L.Name = "SEARCH_BUYER_L";
            this.SEARCH_BUYER_L.Size = new System.Drawing.Size(301, 39);
            this.SEARCH_BUYER_L.TabIndex = 0;
            this.SEARCH_BUYER_L.Text = "SEARCH BUYER";
            // 
            // SEARCH_TYPE_L
            // 
            this.SEARCH_TYPE_L.AutoSize = true;
            this.SEARCH_TYPE_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_TYPE_L.Location = new System.Drawing.Point(7, 74);
            this.SEARCH_TYPE_L.Name = "SEARCH_TYPE_L";
            this.SEARCH_TYPE_L.Size = new System.Drawing.Size(172, 25);
            this.SEARCH_TYPE_L.TabIndex = 1;
            this.SEARCH_TYPE_L.Text = "SEARCH TYPE";
            // 
            // L_SEARCH_BUYER
            // 
            this.L_SEARCH_BUYER.AutoSize = true;
            this.L_SEARCH_BUYER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_SEARCH_BUYER.Location = new System.Drawing.Point(362, 76);
            this.L_SEARCH_BUYER.Name = "L_SEARCH_BUYER";
            this.L_SEARCH_BUYER.Size = new System.Drawing.Size(190, 25);
            this.L_SEARCH_BUYER.TabIndex = 2;
            this.L_SEARCH_BUYER.Text = "SEARCH BUYER";
            // 
            // SEARCH_BUYER_T
            // 
            this.SEARCH_BUYER_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_BUYER_T.Location = new System.Drawing.Point(558, 75);
            this.SEARCH_BUYER_T.Name = "SEARCH_BUYER_T";
            this.SEARCH_BUYER_T.Size = new System.Drawing.Size(157, 26);
            this.SEARCH_BUYER_T.TabIndex = 3;
            this.SEARCH_BUYER_T.TextChanged += new System.EventHandler(this.SEARCH_BUYER_T_TextChanged);
            // 
            // SEARCH_TYPE_C
            // 
            this.SEARCH_TYPE_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_TYPE_C.FormattingEnabled = true;
            this.SEARCH_TYPE_C.Items.AddRange(new object[] {
            "ID",
            "FIRST NAME",
            "LAST NAME",
            "CELL NO",
            "BLOOD TYPE",
            "DATE OF DONATION"});
            this.SEARCH_TYPE_C.Location = new System.Drawing.Point(185, 74);
            this.SEARCH_TYPE_C.Name = "SEARCH_TYPE_C";
            this.SEARCH_TYPE_C.Size = new System.Drawing.Size(166, 28);
            this.SEARCH_TYPE_C.TabIndex = 4;
            // 
            // BACK_B
            // 
            this.BACK_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK_B.Location = new System.Drawing.Point(754, 68);
            this.BACK_B.Name = "BACK_B";
            this.BACK_B.Size = new System.Drawing.Size(149, 37);
            this.BACK_B.TabIndex = 5;
            this.BACK_B.Text = "BACK";
            this.BACK_B.UseVisualStyleBackColor = true;
            this.BACK_B.Click += new System.EventHandler(this.BACK_B_Click);
            // 
            // SEARCH_BUYER_TA
            // 
            this.SEARCH_BUYER_TA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SEARCH_BUYER_TA.Location = new System.Drawing.Point(12, 121);
            this.SEARCH_BUYER_TA.Name = "SEARCH_BUYER_TA";
            this.SEARCH_BUYER_TA.Size = new System.Drawing.Size(742, 303);
            this.SEARCH_BUYER_TA.TabIndex = 6;
            // 
            // SearchBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(915, 442);
            this.Controls.Add(this.SEARCH_BUYER_TA);
            this.Controls.Add(this.BACK_B);
            this.Controls.Add(this.SEARCH_TYPE_C);
            this.Controls.Add(this.SEARCH_BUYER_T);
            this.Controls.Add(this.L_SEARCH_BUYER);
            this.Controls.Add(this.SEARCH_TYPE_L);
            this.Controls.Add(this.SEARCH_BUYER_L);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifa Blood Bank";
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_BUYER_TA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SEARCH_BUYER_L;
        private System.Windows.Forms.Label SEARCH_TYPE_L;
        private System.Windows.Forms.Label L_SEARCH_BUYER;
        private System.Windows.Forms.TextBox SEARCH_BUYER_T;
        private System.Windows.Forms.ComboBox SEARCH_TYPE_C;
        private System.Windows.Forms.Button BACK_B;
        private System.Windows.Forms.DataGridView SEARCH_BUYER_TA;
    }
}