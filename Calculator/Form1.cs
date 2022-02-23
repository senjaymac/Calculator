using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Declaration
        bool valueEntered = false;
        string Operan = " ";
        Double Output = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Trigonometry_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }



        private void Backspace_Click(object sender, EventArgs e)
        {
            if (Numberbox.Text.Length > 0)
            {
                Numberbox.Text = Numberbox.Text.Remove(Numberbox.Text.Length - 1, 1);
            }
            if(Numberbox.Text == " ")
            {
                Numberbox.Text = "0";
            }
        }

        private void Number_click(object sender, EventArgs e)
        {
            if (Numberbox.Text == "0" || (valueEntered))
            
                Numberbox.Text = " ";
            valueEntered = false;

            Button num = (Button)sender;

            if (num.Text == ".")
            {
                    if (!Numberbox.Text.Contains("."))
                        Numberbox.Text = Numberbox.Text + num.Text;
            }
            else
                    Numberbox.Text = Numberbox.Text + num.Text;
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Numberbox.Clear();
            Emptylabel.Text = " ";
        }

        private void Operands_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            Operan = num.Text;

            Output = Double.Parse(Numberbox.Text);
            Numberbox.Text = " ";
            Emptylabel.Text = Output + " " + Operan;

        }

        private void Equate_Click(object sender, EventArgs e)
        {
            switch (Operan)
            {
                case "+":
                Numberbox.Text = (Output + Double.Parse(Numberbox.Text)).ToString();
                    break;
                case "-":
                    Numberbox.Text = (Output - Double.Parse(Numberbox.Text)).ToString();
                    break;
                case "÷":
                    Numberbox.Text = (Output / Double.Parse(Numberbox.Text)).ToString();
                    break;
                case "*":
                    Numberbox.Text = (Output * Double.Parse(Numberbox.Text)).ToString();
                    break;
                case "Mod":
                    Numberbox.Text = (Output % Double.Parse(Numberbox.Text)).ToString();
                    break;
            }
        }

        private void pie_Click(object sender, EventArgs e)
        {
            Numberbox.Text = "3.14159265358997";
        }

        private void log_Click(object sender, EventArgs e)
        {
            double nlog = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "log" + "(" + (Numberbox.Text) +")";
            nlog = Math.Log10(nlog);
            Numberbox.Text = nlog.ToString();
             
        }

        private void x2_Click(object sender, EventArgs e)
        {
            double x2 = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "sqrt" + "(" + (Numberbox.Text) +")";
            x2 = Math.Sqrt(x2);
            Numberbox.Text = x2.ToString();
        }

        private void Sec_Click(object sender, EventArgs e)
        {
            double sec = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "Sec" + "(" + (Numberbox.Text) +")";
            sec = Math.Sinh(sec);
            Numberbox.Text = sec.ToString();
        }

        private void Csc_Click(object sender, EventArgs e)
        {
            double csc = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "Csc" + "(" + (Numberbox.Text) +")";
            csc = Math.Cosh(csc);
            Numberbox.Text = csc.ToString();
        }

        private void Cot_Click(object sender, EventArgs e)
        {
            double cot = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "Cot" + "(" + (Numberbox.Text)+")";
            cot = Math.Tanh(cot);
            Numberbox.Text = cot.ToString();
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "sin" + "("+ (Numberbox.Text)+")";
            sin = Math.Sin(sin);
            Numberbox.Text = sin.ToString();
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "Cos" + "(" + (Numberbox.Text)+")";
            cos = Math.Cos(cos);
            Numberbox.Text = cos.ToString();
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "Tan" + "(" + (Numberbox.Text) +")";
            tan = Math.Tan(tan);
            Numberbox.Text = tan.ToString();
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Numberbox.Text);
            Numberbox.Text = System.Convert.ToString(a, 2);
        }

        private void Hex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Numberbox.Text);
            Numberbox.Text = Numberbox.Text = System.Convert.ToString(a, 16);
        }

        private void Oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Numberbox.Text);
            Numberbox.Text = Numberbox.Text = System.Convert.ToString(a, 8);
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Numberbox.Text);
            Numberbox.Text = Numberbox.Text = System.Convert.ToString(a);
        }

        private void square_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(Numberbox.Text) * Convert.ToDouble(Numberbox.Text);
            Numberbox.Text = a.ToString();

        }

        private void Cube_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(Numberbox.Text) * Convert.ToDouble(Numberbox.Text) * Convert.ToDouble(Numberbox.Text);
            Numberbox.Text = a.ToString();
        }

        private void half_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(Numberbox.Text));
            Numberbox.Text = a.ToString();
        }

        private void lnx_Click(object sender, EventArgs e)
        {
            double nlog = Double.Parse(Numberbox.Text);
            Emptylabel.Text = "log" + "(" + (Numberbox.Text) + ")";
            nlog = Math.Log(nlog);
            Numberbox.Text = nlog.ToString();
        }

        private void percent_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(Numberbox.Text) / Convert.ToDouble(100);
            Numberbox.Text = System.Convert.ToString(a);

        }


    }
}
