using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingManagementApplication
{
    public partial class RegDist : Form
    {
        public RegDist()
        {
            InitializeComponent();
        }

        private void buttonpicture_Click(object sender, EventArgs e)
        {
            FileDialog filedialog= new OpenFileDialog();
            var pict=filedialog.ShowDialog();
            string filename = "";
            if(pict==DialogResult.OK)
            {
               filename= filedialog.FileName;
            }
            MessageBox.Show(filename);
        }
        static int indexdt = 0;
        private void registrationbut_Click(object sender, EventArgs e)
        { 
            
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
           
            try
            {
              
                sql.Open();
                SqlCommand getid = new SqlCommand("select Max([DistributorID]) from Distributor;", sql);//geting last id
                SqlCommand getcont = new SqlCommand("select count([DistributorID]) from Distributor;", sql);
                for (int i = 0; i < (int)getcont.ExecuteScalar(); i++)
                {
                    rekomenda.Add(i,0);//pirveli  achvenebs rigs meore  ramdeni vinme daamata
                }
                MessageBox.Show(rekomenda.Count.ToString());
                int a = (int)getid.ExecuteScalar();
                if (a == null)
                {
                    indexdt = 1;
                }
                else
                {
                    indexdt = a++;
                }
              
                //MessageBox.Show(indexdt.ToString());
                #region Distributor table
               
                string name =textBoxName.Text;
                string lastname=textBoxLastname.Text;
               
                DateTime birth = dateTimePickerbirthdate.Value;

                MessageBox.Show("zd");
                String gender =comboBoxGender.SelectedItem.ToString();
                string com = $"insert into Distributor ([FirstName],[LastName],[BirthDate],[Gender]) values('{name}','{lastname}','{birth.ToShortDateString()}','{gender}') ";
            
                SqlCommand sqlcom= new SqlCommand(com,sql);
                sqlcom.ExecuteNonQuery();
                #endregion
                

                #region contact table
                string kontaqctType=comboBoxcontacttype.SelectedItem.ToString();
                string contact=textBoxcontactInfo.Text;
                string com1=$"insert into ContactInfo (ContactType,ContInfo,DistributorID) values('{kontaqctType}','{contact}',{indexdt})";
                SqlCommand sqlcom1= new SqlCommand(com1,sql);
                sqlcom1.ExecuteNonQuery();

                #endregion
                #region address
                string adresstype = comboBoxAddressType.SelectedItem.ToString();
                string adress = textBoxAddress.Text;
                string com2 = $"insert into Addresses (AddressType,AddresInfo,DistributorID) values ('{adresstype}','{adress}',{indexdt})";
                SqlCommand sqlcom2 = new SqlCommand(com2, sql);
                sqlcom2.ExecuteNonQuery();
                #endregion

                #region Documents
                string doctype=comboBoxDocumentType.SelectedItem.ToString();
                string docseria=textBoxDocumentSeria.Text;
                string docnumber=textBoxDocumentNumber.Text;
                DateTime dateofissue=dateTimePickerIssue.Value;
                DateTime expirydate=dateTimePickerexpiry.Value;
                string persnumber=textBoxPersonalNumber.Text;
                string issuingauthority=textBoxissuer.Text;
                string com3 = $"insert into PersonalINfo (DocType,DocSeria,DocNumber,DateOfIssue,ExpiryDate,PersonalNumber,IssuingAuthority,DistributorID) values ('{doctype}','{docseria}','{docnumber}','{dateofissue.ToShortDateString()}','{expirydate.ToShortDateString()}','{persnumber}','{issuingauthority}',{indexdt})";
                SqlCommand sqlcom3= new SqlCommand(com3,sql);
                sqlcom3.ExecuteNonQuery();
                #endregion

                int indxofrek = int.Parse(comboBoxRekomendator.SelectedItem.ToString().Split('-')[1]);
                rekomenda[indxofrek]++;
                MessageBox.Show("Distributori warmatebit daemata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally { sql.Close(); }
        }

        static List<string> list = new List<string>();
        Dictionary<int,int> rekomenda = new Dictionary<int,int>();
        private void Onchanged(object sender, EventArgs e)
        {
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
            sql.Open();

            SqlCommand scm = new SqlCommand("select [FirstName],[DistributorID] from [dbo].[Distributor]", sql);
            SqlDataReader dat = scm.ExecuteReader();
            int i = 0;
            while (dat.Read())
            {
                if (rekomenda[i] > 3)//samze meti rekomendacia gasca
                {

                    Console.WriteLine($"distributori nomeri : {i} vegar gascems met rekomendacias airchie sxva");
                }
                else
                {
                    list.Add(dat[0].ToString() + "-" + dat[1]);
                }
                i++;
            }
            comboBoxRekomendator.DataSource = list;
        }
    

        private void RegDist_Load(object sender, EventArgs e)
        {
            string conect = "server=.;database=MarketingManagementApp;trusted_connection=true";
            SqlConnection sql = new SqlConnection(conect);
            sql.Open();

            SqlCommand getcont = new SqlCommand("select count([DistributorID]) from Distributor;", sql);
            for (int j = 0; j < (int)getcont.ExecuteScalar(); j++)
            {
                rekomenda.Add(j, 0);//pirveli  achvenebs rigs meore  ramdeni vinme daamata
            }

            SqlCommand scm = new SqlCommand("select [FirstName],[DistributorID] from [dbo].[Distributor]", sql);

            SqlDataReader dat = scm.ExecuteReader();
        int i = 0;
            while (dat.Read())
            {
                if (rekomenda[i] > 3)
                {

                
                } else
                {
                    list.Add(dat[0].ToString() + "-" + dat[1]);
                }
            i++;
            }
            comboBoxRekomendator.DataSource = list;
        }
    }
}
