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
    public partial class FillterofDist : Form
    {
        public FillterofDist()
        {
            InitializeComponent();
        }

        private void FillterofDist_Load(object sender, EventArgs e)
        {
            dataGridViewfordistr.Rows.Clear();
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
            sql.Open();
            SqlCommand cmd = new SqlCommand("select [FirstName],[prodQuantity],[LastName],[SaleDate],[Name], [Price]from [dbo].[DistSale] ds join [dbo].[Distributor] dst on dst.DistributorID=ds.DistributorID join [dbo].[Product] prd on prd.ProductID=ds.ProductID", sql);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
            DataTable dataTable = new DataTable(); 

            adapter.Fill(dataTable); 
            dataGridViewfordistr.DataSource = dataTable;
            dataGridViewfordistr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            sql.Close();
        }

        private void dataGridViewfordistr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
