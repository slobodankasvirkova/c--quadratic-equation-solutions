using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double a, b, c, D;

        private void заАпликацијатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ова претставува апликација за пресметување на квадратни равенки кои можат да имаат реални или имагинарни решенија.");
        }

        private void контактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("slobodanka.102065@student.ugd.edu.mk");
        }

        private void излезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            textBox6.Enabled = true;
            textBox7.Visible = true;
            textBox7.Enabled = true;
            label9.Visible = true;
            label9.Enabled = true;
            label10.Visible = true;
            label10.Enabled = true;
            label11.Visible = true;
            label11.Enabled = true;
            label12.Visible = true;
            label12.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Внесете ги сите коефициенти!");


            }
            else
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                D = Math.Pow(b, 2.0) - 4.0 * a * c;
                if (a == 0)
                {
                    MessageBox.Show("Коефициентот а треба да е различен од 0!");

                }

                if (D >= 0)
                {

                    textBox4.Text = ((-b + (Math.Sqrt(D))) / (2.0 * a)).ToString();
                    textBox5.Text = ((-b - (Math.Sqrt(D))) / (2.0 * a)).ToString();
                    textBox6.Visible = false;
                    textBox6.Enabled = false;
                    textBox7.Visible = false;
                    textBox7.Enabled = false;
                    label9.Visible = false;
                    label9.Enabled = false;
                    label10.Visible = false;
                    label10.Enabled = false;
                    label11.Visible = false;
                    label11.Enabled = false;
                    label12.Visible = false;
                    label12.Enabled = false;


                }
                else if (D < 0)
                {
                    textBox4.Text = ((-b / (2.0 * a))).ToString();
                    textBox5.Text = ((-b / (2.0 * a))).ToString();
                    textBox6.Text = ((Math.Sqrt(-D)) / 2.0 * a).ToString();
                    textBox7.Text = ((Math.Sqrt(-D)) / 2.0 * a).ToString();
                }


            }
        } 

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Внесете сами целобројни коефициенти помеѓу(-999,999) и притиснетe\n на копчето подолу за да биде решена квадратната равенка";
            label3.Text = "X^2";
            label4.Text = "X";
            label5.Text = "=0";
            label6.Text = "Корени/решенија на равенката:";
            this.Text = "Калкулатор за квадратни равенки";
            this.Cursor = Cursors.Hand;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.BackColor = Color.Beige;
            

            

        }

        
    }
}
