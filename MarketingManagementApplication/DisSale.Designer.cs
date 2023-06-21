namespace MarketingManagementApplication
{
    partial class DisSale
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
            this.comboBoxdistr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSaleProd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSaleProdcount = new System.Windows.Forms.TextBox();
            this.textBoxAllSale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxprodpric = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "დისტრიბუტორი(რომელმაც გაყიდა პროდუქტი)";
            // 
            // comboBoxdistr
            // 
            this.comboBoxdistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxdistr.FormattingEnabled = true;
            this.comboBoxdistr.Location = new System.Drawing.Point(594, 40);
            this.comboBoxdistr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxdistr.Name = "comboBoxdistr";
            this.comboBoxdistr.Size = new System.Drawing.Size(333, 28);
            this.comboBoxdistr.TabIndex = 1;
            this.comboBoxdistr.SelectedIndexChanged += new System.EventHandler(this.comboBoxdistr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "გაყიდვის თარიღი";
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(594, 110);
            this.dateTimePickerSaleDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(333, 26);
            this.dateTimePickerSaleDate.TabIndex = 3;
            this.dateTimePickerSaleDate.ValueChanged += new System.EventHandler(this.dateTimePickerSaleDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "გაყიდული პროდუქცია";
            // 
            // comboBoxSaleProd
            // 
            this.comboBoxSaleProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSaleProd.FormattingEnabled = true;
            this.comboBoxSaleProd.Location = new System.Drawing.Point(594, 188);
            this.comboBoxSaleProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSaleProd.Name = "comboBoxSaleProd";
            this.comboBoxSaleProd.Size = new System.Drawing.Size(333, 28);
            this.comboBoxSaleProd.TabIndex = 5;
            this.comboBoxSaleProd.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaleProd_SelectedIndexChanged);
            this.comboBoxSaleProd.TextChanged += new System.EventHandler(this.OnProductchanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(28, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "გაყიდული პროდუქციის რაოდენობა";
            // 
            // textBoxSaleProdcount
            // 
            this.textBoxSaleProdcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSaleProdcount.Location = new System.Drawing.Point(594, 347);
            this.textBoxSaleProdcount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSaleProdcount.Name = "textBoxSaleProdcount";
            this.textBoxSaleProdcount.Size = new System.Drawing.Size(333, 26);
            this.textBoxSaleProdcount.TabIndex = 9;
            this.textBoxSaleProdcount.TextChanged += new System.EventHandler(this.Quantitychangedaction);
            // 
            // textBoxAllSale
            // 
            this.textBoxAllSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAllSale.Location = new System.Drawing.Point(594, 426);
            this.textBoxAllSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAllSale.Name = "textBoxAllSale";
            this.textBoxAllSale.Size = new System.Drawing.Size(333, 26);
            this.textBoxAllSale.TabIndex = 14;
            this.textBoxAllSale.TextChanged += new System.EventHandler(this.textBoxAllSale_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(28, 428);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "გაყიდული პროდუქციის საერთო ფასი";
            // 
            // buttonReg
            // 
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReg.Location = new System.Drawing.Point(645, 498);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(324, 50);
            this.buttonReg.TabIndex = 15;
            this.buttonReg.Text = "რეგისტრაცია";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxprodpric
            // 
            this.textBoxprodpric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxprodpric.Location = new System.Drawing.Point(594, 258);
            this.textBoxprodpric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxprodpric.Name = "textBoxprodpric";
            this.textBoxprodpric.Size = new System.Drawing.Size(333, 26);
            this.textBoxprodpric.TabIndex = 16;
            this.textBoxprodpric.TextChanged += new System.EventHandler(this.textBoxprodpric_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "გაყიდული პროდუქციის ღირებულება";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "ფილტრზე გადასვლა";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxprodpric);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxAllSale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSaleProdcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSaleProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerSaleDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxdistr);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DisSale";
            this.Text = "DisSale";
            this.Load += new System.EventHandler(this.DisSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxdistr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSaleProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSaleProdcount;
        private System.Windows.Forms.TextBox textBoxAllSale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxprodpric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}