using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingManagementApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegDist regDist= new RegDist();
            regDist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegProd regProd= new RegProd();
            regProd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisSale dissale= new DisSale();
            dissale.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BonusCalc bonusCalc= new BonusCalc();
            bonusCalc.Show();
        }

        private void OnmouseEntered(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
        }

        private void onmouseleaved(object sender, EventArgs e)
        {
            Button bt=(Button)sender;
            bt.BackColor = clr;
        }
        static Color clr;
        private void Form1_Load(object sender, EventArgs e)
        {
           clr = button1.BackColor;
        }
    }
}
