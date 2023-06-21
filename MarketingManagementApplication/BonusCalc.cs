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
    public partial class BonusCalc : Form
    {
        public BonusCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // dataGridViewforbonus.Rows.Clear();
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
            try
            {
            
                sql.Open();
                DateTime startdate = dateTimePickerstarter.Value;
                DateTime enddate = dateTimePickerender.Value;
                SqlCommand cmd = new SqlCommand($"select [FirstName],[LastName],([totalPrice])*10/100 as bonus  from [dbo].[DistSale] ds join [dbo].[Distributor] sd on  sd.DistributorID=ds.DistributorID where [SaleDate]  between '{startdate.ToShortDateString()}' and  '{enddate.ToShortDateString()}'", sql);
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                dataGridViewforbonus.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                sql.Close();
            }
        }

        private void dataGridViewforbonus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BonusCalc_Load(object sender, EventArgs e)
        {

            //dataGridViewforbonus.Rows.Clear();
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
            sql.Open();
            SqlCommand cmd = new SqlCommand(" select [FirstName],[LastName],([totalPrice])*10/100 as bonus  from [dbo].[DistSale] ds join [dbo].[Distributor] sd on  sd.DistributorID=ds.DistributorID", sql);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            dataGridViewforbonus.DataSource = dataTable;
            dataGridViewforbonus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            sql.Close();
        }
    }
}
