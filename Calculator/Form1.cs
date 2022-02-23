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
    }
}
