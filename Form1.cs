using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 面积计算器
{
    public partial class Form1 : Form
    {
        double unit = 1;//设置单位
        public Form1()
        {
            InitializeComponent();
        }
       
        public class CGraph
        {
            public CGraph()
            {

            }
            public double calculate(double a)
            {
                double area = Math.PI * a * a/4;
                return Math.Round(area, 3);
            }

            public double calculate(double a, double b)
            {
                double area = a * b;
                return Math.Round(area, 3);
            }
            public double calculate1(double a, double b)
            {
                double area = a * b / 2;
           
                return Math.Round(area, 3);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1 .Text == "单位：cm")
            {
                button1.Text = "单位：in";
                unit= 2.54;
            }

            else
            {
                button1.Text = "单位：cm";
                unit = 1;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "单位：cm")
            {
                button2.Text = "单位：in";
                unit = 2.54;
            }

            else
            {
                button2.Text = "单位：cm";
                unit = 1;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "单位：cm")
            {
                button3.Text = "单位：in";
                unit = 2.54;
            }

            else
            {
                button3.Text = "单位：cm";
                unit = 1;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "单位：cm")
            {
                button4.Text = "单位：in";
                unit = 2.54;
            }

            else
            {
                button4.Text = "单位：cm";
                unit = 1;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            CGraph cgraph = new CGraph();
            if (tabControl1.SelectedIndex == 0 && textBox1.Text.Trim() != " ")
            {
                double r = double.Parse(textBox1.Text);//r为边长
                if (r > 0)
                {
            
                    MessageBox.Show("边长为 " + r *unit+"cm" + " 的正方形的面积是：" + cgraph.calculate(r, r) * unit * unit + " cm\x00b2");
                }
                else
                {
                    MessageBox.Show("数据有误，请重新输入");
                }



            }
            else if (tabControl1.SelectedIndex == 1 && textBox2.Text.Trim() != " " && textBox3.Text.Trim() != " ")
            {

                double r = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                if (r > 0 && c > 0)
                {
                    MessageBox.Show("长为 " + r * unit + "cm" + " 宽为 " + c * unit + "cm" + " 的长方形的面积是：" + cgraph.calculate(r, c) * unit * unit + " cm\x00b2");
                 

                }
                else
                {
                    MessageBox.Show("数据有误，请重新输入");
                }

            }
            else if (tabControl1.SelectedIndex == 2 && textBox4.Text.Trim() != " " && textBox5.Text.Trim() != " ")
            {
                double r = double.Parse(textBox4.Text);
                double c = double.Parse(textBox5.Text);

                if (r > 0 && c > 0)
                {
                    MessageBox.Show("底为 " + r * unit + "cm" + "高为" + c * unit + "cm" + " 的三角形的面积是：" + cgraph.calculate1(r, c) * unit * unit + "cm\x00b2");

                }
                else
                {
                    MessageBox.Show("数据有误，请重新输入");
                }
            }
            else if (tabControl1.SelectedIndex == 3 && textBox6.Text.Trim() != " ")
            {
                double r = double.Parse(textBox6.Text);
                if (r > 0)
                {
                    MessageBox.Show("直径为 " + r * unit + "cm" + " 的圆的面积是：" + cgraph.calculate(r) * unit * unit + "cm\x00b2");

                }
                else
                {
                    MessageBox.Show("数据有误，请重新输入");
                }

            }
        }
    }
}
