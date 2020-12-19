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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {


            ketqua rs = new ketqua();
            
            #region nhap a,b,c và tính ptb2  
            double a = 0, b = 0, c = 0;
            if (double.TryParse(A.Text, out a))
            {
                
                if (double.TryParse(B.Text, out b))
                {
                    
                    if (double.TryParse(C.Text, out c))
                    {
                        lb6.Text = "giá trị nhập thỏa mãn!!";
                        
                        { 
                            rs.lb1.Text = "phương trình nhập vào là: " + a.ToString() + "X^2 + " + b.ToString() + "X + " + c.ToString() + " = 0";
                            tinhtoanB2();
                            rs.ShowDialog();
                        }

                    }
                    else
                        lb6.Text = "C không phải số! vui lòng nhập lại số !!!";
                }
                else
                    lb6.Text = "B không phải số! vui lòng nhập lại số !!!";
            }
            else
                lb6.Text = "A không phải số! vui lòng nhập lại số !!!";

            #endregion


            #region hàm tính ptb2

            void tinhtoanB2()
            {
                double dta = (b * b) - (4 * a * c);
                if (dta < 0)
                {
                    rs.lb2.Text = "phương trình vô nghiệm";
                }
                else if (dta == 0)
                {
                    rs.lb2.Text = "phương trình có nghiệm kép\n x=" + (-b / (2 * a)).ToString();
                }
                else
                {
                    rs.lb2.Text = "x1 = " + ((-b + Math.Sqrt(dta)) / (2 * a)).ToString() + "\nx2 = " + ((-b - Math.Sqrt(dta)) / (2 * a)).ToString();
                }
            }
            #endregion


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ptbac1 pt1 = new ptbac1();
            pt1.Show();
            this.Hide();
        }
    }
}
