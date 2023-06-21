using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingManagementApplication
{
    public partial class RegProd : Form
    {
        public RegProd()
        {
            InitializeComponent();
        }

        private void buttonRegProduc_Click(object sender, EventArgs e)
        {
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql=new SqlConnection(conect);
            try
            {
                sql.Open();
                 string Name=textBoxprodName.Text;
                 decimal itemPric=decimal.Parse(textBoxItemPrice.Text);
                if (Name.Length==0||itemPric==0 )
                {
                    MessageBox.Show("scadet tavidan");
                    textBoxItemPrice.Clear();
                    textBoxprodName.Clear();
                }
                 string com = $"insert into Product (Name,Price) values ('{Name}',{itemPric});";
                SqlCommand sqlCommand= new SqlCommand(com,sql);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Producti warmatebit daemata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally { sql.Close(); }
        }
    }
}
