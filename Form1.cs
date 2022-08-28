using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Caculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Unit of caculation.
        /// </summary>
        double unit = 1;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The main form <c>Form1</c>
        /// Contains area caculations including four types of darwings
        /// <list type="bullet">
        /// <item>
        /// <term>Square</term>
        /// <description>S = a * a</description>
        /// </item>
        /// <item>
        /// <term>Rectangle</term>
        /// <description>S = a * b</description>
        /// </item>
        /// <item>
        /// <term>Triangle</term>
        /// <description>S = a * h</description>
        /// </item>
        /// <item>
        /// <term>Circle</term>
        /// <description>S = π * d * d / 4</description>
        /// </item>
        /// </list>
        /// </summary>
        public class CGraph
        {
            public CGraph()
            {

            }

            /// <summary>
            /// Calculates the area of a circle with diameter <paramref name="a"/>,
            /// and return the result.
            /// </summary>
            /// <param name="a">The diameter of the circle.</param>
            /// <returns></returns>
            public double calculate(double a)
            {
                double area = Math.PI * a * a/4;
                return Math.Round(area, 3);
            }

            /// <summary>
            /// Calculates the area of a rectangle with length of side <paramref name="a"/> and <paramref name="b"/>,
            /// and return the result.
            /// </summary>
            /// <param name="a">One side of the rectangle.</param>
            /// <param name="b">Another side of the rectangle. In particular, side <paramref name="b"/> equals to side <paramref name="a"/> in square.</param>
            /// <returns></returns>
            public double calculate(double a, double b)
            {
                double area = a * b;
                return Math.Round(area, 3);
            }

            /// <summary>
            /// Calculates the area of a triangle with length of side <paramref name="a"/> and the height <paramref name="b"/>,
            /// and return the result. 
            /// </summary>
            /// <param name="a">One side of the triangle.</param>
            /// <param name="b">Height of the side <paramref name="a"/> in triangle.</param>
            /// <returns></returns>
            public double calculate1(double a, double b)
            {
                double area = a * b / 2;
           
                return Math.Round(area, 3);
            }


        }

        /// <summary>
        /// Changes the unit between in inches and centimeters when click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Changes the unit between in inches and centimeters when click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Changes the unit between in inches and centimeters when click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Changes the unit between in inches and centimeters when click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Starts the caculation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click_1(object sender, EventArgs e)
        {
            CGraph cgraph = new CGraph();
            if (tabControl1.SelectedIndex == 0)
            {
                double a;
                if (!double.TryParse(textBox1.Text, out a))
                {
                    MessageBox.Show("请正确输入正方形的边长！");
                }
                else
                {
                    if (a > 0)
                    {
                        MessageBox.Show("边长为 " + a * unit + "cm" + " 的正方形的面积是：" + cgraph.calculate(a, a) * unit * unit + " cm\x00b2");
                    }
                    else
                    {
                        MessageBox.Show("正方形边长需大于0！");
                    }
                }

            }

            if (tabControl1.SelectedIndex == 1)
            {

                double a ;
                double b ;

                if (!double.TryParse(textBox2.Text, out a)|| !double.TryParse(textBox3.Text, out b))
                {
                    MessageBox.Show("请正确输入长方形的边长！");
                }
                else
                {
                    if (a > 0 && b > 0)
                    {
                        if (a==b) MessageBox.Show("边长为 " + a * unit + "cm" + " 的正方形的面积是：" + cgraph.calculate(a, b) * unit * unit + " cm\x00b2");
                        else MessageBox.Show("长为 " + a * unit + "cm" + " 宽为 " + b * unit + "cm" + " 的长方形的面积是：" + cgraph.calculate(a, b) * unit * unit + " cm\x00b2");
                    }
                    else
                    {
                        MessageBox.Show("长方形边长需大于0！");
                    }
                }
                

            }

            if (tabControl1.SelectedIndex == 2)
            {
                double a;
                double h;

                if (!double.TryParse(textBox4.Text, out a) || !double.TryParse(textBox5.Text, out h))
                {
                    MessageBox.Show("请正确输入三角形的底和高！");
                }
                else
                {
                    if (a > 0 && h > 0)
                    {
                        MessageBox.Show("底为 " + a * unit + "cm" + "高为" + h * unit + "cm" + " 的三角形的面积是：" + cgraph.calculate1(a, h) * unit * unit + "cm\x00b2");
                    }
                    else
                    {
                        MessageBox.Show("三角形的底和高需大于0！");
                    }
                }
                
            }
            
            if (tabControl1.SelectedIndex == 3)
            {
                double d;
                if (!double.TryParse(textBox6.Text, out d))
                {
                    MessageBox.Show("请正确输入圆形的直径！");
                }
                else
                {
                    if (d > 0)
                    {
                        MessageBox.Show("直径为 " + d * unit + "cm" + " 的圆的面积是：" + cgraph.calculate(d) * unit * unit + "cm\x00b2");

                    }
                    else
                    {
                        MessageBox.Show("圆形的直径需大于0！");
                    }
                } 
            }
        }
    }
}
