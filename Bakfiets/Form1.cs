using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakfiets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {
            
            double[] accessoire={ 1, 2, 3, 4, 5 }; // prijs 1 tm 5 euro
            double[] typeBike = { 10, 15, 20 }; //prijs van de fiets per dag
            double PriceDay = 0;
            double TotalPrice = 0;
            double Days = 0;

            if (CheckBox1.CheckState == CheckState.Checked)
            {
                PriceDay = PriceDay + accessoire[0];
            }
            
            if (CheckBox2.CheckState == CheckState.Checked) 
            {
                PriceDay =  PriceDay +  accessoire [1];
            }
            

            if (CheckBox3.CheckState == CheckState.Checked) 
            {
                PriceDay = PriceDay + accessoire [2];
            }
            
            if (CheckBox4.CheckState == CheckState.Checked) 
            {
               PriceDay = PriceDay +  accessoire [3];
            }
            
            if (CheckBox5.CheckState == CheckState.Checked)
            {
                PriceDay = PriceDay + accessoire [4];
            }

            if (radioButton1.Checked)

            {
                PriceDay = PriceDay + typeBike[0];
            }

            if (radioButton2.Checked)

            {
                PriceDay = PriceDay + typeBike[1];
            }
            if (radioButton3.Checked)

            {
                PriceDay = PriceDay + typeBike[2];
            }

            Days = Convert.ToDouble(textBox1.Text);

            TotalPrice = Days * PriceDay;

            textBox2.Text = Convert.ToString(TotalPrice); 

            
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
