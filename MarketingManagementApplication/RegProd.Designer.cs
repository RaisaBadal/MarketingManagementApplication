namespace MarketingManagementApplication
{
    partial class RegProd
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
            this.textBoxprodName = new System.Windows.Forms.TextBox();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.buttonRegProduc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "პროდუქტის დასახელება";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ერთეულის ფასი";
            // 
            // textBoxprodName
            // 
            this.textBoxprodName.Location = new System.Drawing.Point(345, 51);
            this.textBoxprodName.Name = "textBoxprodName";
            this.textBoxprodName.Size = new System.Drawing.Size(210, 22);
            this.textBoxprodName.TabIndex = 2;
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Location = new System.Drawing.Point(345, 151);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(210, 22);
            this.textBoxItemPrice.TabIndex = 3;
            // 
            // buttonRegProduc
            // 
            this.buttonRegProduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegProduc.Location = new System.Drawing.Point(294, 258);
            this.buttonRegProduc.Name = "buttonRegProduc";
            this.buttonRegProduc.Size = new System.Drawing.Size(242, 34);
            this.buttonRegProduc.TabIndex = 4;
            this.buttonRegProduc.Text = "რეგისტრაცია";
            this.buttonRegProduc.UseVisualStyleBackColor = true;
            this.buttonRegProduc.Click += new System.EventHandler(this.buttonRegProduc_Click);
            // 
            // RegProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegProduc);
            this.Controls.Add(this.textBoxItemPrice);
            this.Controls.Add(this.textBoxprodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegProd";
            this.Text = "RegProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxprodName;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Button buttonRegProduc;
    }
}