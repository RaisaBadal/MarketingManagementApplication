namespace MarketingManagementApplication
{
    partial class BonusCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerstarter = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerender = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewforbonus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforbonus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "საწყისი თარიღი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "საბოლოო თარიღი";
            // 
            // dateTimePickerstarter
            // 
            this.dateTimePickerstarter.Location = new System.Drawing.Point(407, 24);
            this.dateTimePickerstarter.Name = "dateTimePickerstarter";
            this.dateTimePickerstarter.Size = new System.Drawing.Size(251, 22);
            this.dateTimePickerstarter.TabIndex = 2;
            // 
            // dateTimePickerender
            // 
            this.dateTimePickerender.Location = new System.Drawing.Point(407, 76);
            this.dateTimePickerender.Name = "dateTimePickerender";
            this.dateTimePickerender.Size = new System.Drawing.Size(251, 22);
            this.dateTimePickerender.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "გამოთვლა";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewforbonus
            // 
            this.dataGridViewforbonus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewforbonus.Location = new System.Drawing.Point(12, 179);
            this.dataGridViewforbonus.Name = "dataGridViewforbonus";
            this.dataGridViewforbonus.RowHeadersWidth = 51;
            this.dataGridViewforbonus.RowTemplate.Height = 24;
            this.dataGridViewforbonus.Size = new System.Drawing.Size(776, 259);
            this.dataGridViewforbonus.TabIndex = 5;
            this.dataGridViewforbonus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforbonus_CellContentClick);
            // 
            // BonusCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewforbonus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerender);
            this.Controls.Add(this.dateTimePickerstarter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BonusCalc";
            this.Text = "BonusCalc";
            this.Load += new System.EventHandler(this.BonusCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewforbonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerstarter;
        private System.Windows.Forms.DateTimePicker dateTimePickerender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewforbonus;
    }
}