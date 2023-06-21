namespace MarketingManagementApplication
{
    partial class FillterofDist
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
            this.dataGridViewfordistr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfordistr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewfordistr
            // 
            this.dataGridViewfordistr.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridViewfordistr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfordistr.Location = new System.Drawing.Point(4, 2);
            this.dataGridViewfordistr.Name = "dataGridViewfordistr";
            this.dataGridViewfordistr.RowHeadersWidth = 51;
            this.dataGridViewfordistr.RowTemplate.Height = 24;
            this.dataGridViewfordistr.Size = new System.Drawing.Size(793, 451);
            this.dataGridViewfordistr.TabIndex = 0;
            this.dataGridViewfordistr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewfordistr_CellContentClick);
            // 
            // FillterofDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewfordistr);
            this.Name = "FillterofDist";
            this.Text = "FillterofDist";
            this.Load += new System.EventHandler(this.FillterofDist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfordistr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewfordistr;
    }
}