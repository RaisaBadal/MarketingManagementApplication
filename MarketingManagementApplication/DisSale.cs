using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingManagementApplication
{
    public partial class DisSale : Form
    {
        public DisSale()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sqlconn = new SqlConnection(conect);

            try
            {
                sqlconn.Open();
                string st = comboBoxdistr.SelectedItem.ToString();
                string name = st.Split('-')[0];
                int iddist = int.Parse(st.Split('-')[1]);
                DateTime datesale = dateTimePickerSaleDate.Value;
                string gayid = comboBoxSaleProd.SelectedItem.ToString().Split('-')[0];
                int IDProd = int.Parse(comboBoxSaleProd.SelectedItem.ToString().Split('-')[1]);
                decimal fasi = decimal.Parse(textBoxprodpric.Text);
                int quantity = int.Parse(textBoxSaleProdcount.Text);
                decimal total = decimal.Parse(textBoxAllSale.Text);

                string comins = $"insert into DistSale(DistributorID,SaleDate,ProductID,prodQuantity,totalPrice) values ({iddist},'{datesale.ToShortDateString()}',{IDProd},{quantity},{total})";
                SqlCommand sqlco = new SqlCommand(comins, sqlconn);
                sqlco.ExecuteNonQuery();
                MessageBox.Show("warmatebuli operacia");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally { sqlconn.Close(); }
           
            




        }

        private void DisSale_Load(object sender, EventArgs e)
        {
            textBoxprodpric.Enabled = false;
            textBoxAllSale.Enabled = false;
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
            sql.Open();

            SqlCommand scm = new SqlCommand("select [FirstName],[DistributorID] from [dbo].[Distributor]", sql);
            SqlDataReader dat= scm.ExecuteReader();
            List<string> list = new List<string>();
            while(dat.Read())
            {
                list.Add(dat[0].ToString()+"-" + dat[1]);
            }
            comboBoxdistr.DataSource= list;
            dat.Close();
            //////////////////////////////////////////
            SqlCommand scm1 = new SqlCommand("select Name,[ProductID] from Product", sql);
            SqlDataReader data = scm1.ExecuteReader();
            List<string> list1 = new List<string>();
            while (data.Read())
            {
                list1.Add(data[0].ToString() + "-" + data[1]);
            }
            comboBoxSaleProd.DataSource = list1;
            data.Close();
         

            sql.Close();
        }

        private void OnProductchanged(object sender, EventArgs e)
        {
            
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
            try
            {
                sql.Open();
                ///////////////////////////////////
                ///
                string st = comboBoxSaleProd.Text;
                int index = int.Parse(st.Split('-')[1]);
             
                SqlCommand scm2 = new SqlCommand($"select [Price] from Product where [ProductID] ={index}", sql);
                var data1 = scm2.ExecuteScalar();  
           
                textBoxprodpric.Text = data1.ToString();
                // comboBoxSalePrice.DataSource = list2;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally { sql.Close(); }
    
        }

        private void Quantitychangedaction(object sender, EventArgs e)
        {
          
                try
                {
                int qua;
                    
                if (int.TryParse(textBoxSaleProdcount.Text,out qua)==false)
                {
                    // MessageBox.Show("sheiyvanet raodenoba");

                }
                else
                {
                    int quan = int.Parse(textBoxSaleProdcount.Text);
                    decimal price = decimal.Parse(textBoxprodpric.Text);
                    textBoxAllSale.Text = (quan * price).ToString();

                }

              

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                    MessageBox.Show(es.StackTrace);
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillterofDist flt=new FillterofDist();

            flt.Show();

        }

        private void comboBoxSaleProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxprodpric_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxdistr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAllSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerSaleDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
