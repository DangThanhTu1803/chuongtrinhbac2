using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ptbac1 : Form
    {
        public ptbac1()
        {
            InitializeComponent();
        }
        public bool IsClose { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            ketqua rs = new ketqua();

            double a = 0, b = 0;

            if (A.Text != null)
            {

            
            if (double.TryParse(A.Text, out a))
            {

                if (double.TryParse(B.Text, out b))
                {
                    rs.lb1.Text = "phương trình nhập vào là: " + a.ToString() + "X + " + b.ToString() + " = 0";
                    tinhtoanB1();
                    rs.ShowDialog();
                }
                else
                    label3.Text = "B không phải số! vui lòng nhập lại số !!!";
            }
            else
                label3.Text = "A không phải số! vui lòng nhập lại số !!!";
            }
            else
                label3.Text = " Chưa nhập A";
            void tinhtoanB1()
            {
                if (a == 0 && b == 0)
                {
                    rs.lb2.Text = "phương trình có vô số nghiệm";
                }
                else if (a == 0 && b != 0)
                {
                    rs.lb2.Text = "phương trình vô nghiệm";
                }
                else
                {
                    double kqua = (-b) / a;
                    rs.lb2.Text = "phương trình có 1 nghiệm: \nX = " + kqua.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsClose = false;
            Form1 pt2 = new Form1();
            pt2.Show();
            this.Close();
        }
        
    }
}
