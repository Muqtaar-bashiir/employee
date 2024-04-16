using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {

            double sub1,sub2,sub3,sub4,sub5,sub6,sub7,sub8,total,name;

            sub1 = Convert.ToInt16(txtsub1.Text);
            sub2 = Convert.ToInt16(txtsub2.Text);
            sub3 = Convert.ToInt16(txtsub3.Text);
            sub4 = Convert.ToInt16(txtsub4.Text);
            sub5 = Convert.ToInt16(txtsub5.Text);
            sub6 = Convert.ToInt16(txtsub6.Text);
            sub7 = Convert.ToInt16(txtsub7.Text);
            sub8 = Convert.ToInt16(txtsub8.Text);

            total = sub1 + sub2 + sub3 + sub4 + sub5 + sub6 + sub7 + sub8;
            lbltotal.Text = total.ToString();   
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsub1.Text = "";
            txtsub2.Text = "";
            txtsub3.Text = "";
            txtsub4.Text = "";
            txtsub5.Text = "";
            txtsub6.Text = "";
            txtsub7.Text = "";
            txtsub8.Text = "";
            lbltotal.Text = "";
        }

        private void bbtndelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
