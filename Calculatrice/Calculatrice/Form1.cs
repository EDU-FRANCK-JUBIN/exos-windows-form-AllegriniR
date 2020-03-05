using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        private double firstnumber;
        private string secondnumber = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void clickNombre(object sender)
        {
            if (Calcul.Text[Calcul.Text.Length - 1] != '=')
            {
                Button button = (Button)sender;
                Calcul.Text += button.Text;
                secondnumber += button.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Calcul.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clickNombre(sender);
        }

        private void Calcul_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Calcul.Text[Calcul.Text.Length-1] != '=' &&
                Calcul.Text[Calcul.Text.Length-1] != '+' &&
                Calcul.Text[Calcul.Text.Length-1] != '-' &&
                Calcul.Text[Calcul.Text.Length-1] != '/' &&
                Calcul.Text[Calcul.Text.Length-1] != '*')
            {
                Calcul.Text += button.Text;
                firstnumber = Convert.ToDouble(Resultat.Text);
                Resultat.Text = Convert.ToString(firstnumber * Convert.ToDouble(secondnumber));
                secondnumber = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Calcul.Text[Calcul.Text.Length - 1] != '=' &&
                Calcul.Text[Calcul.Text.Length - 1] != '+' &&
                Calcul.Text[Calcul.Text.Length - 1] != '-' &&
                Calcul.Text[Calcul.Text.Length - 1] != '/' &&
                Calcul.Text[Calcul.Text.Length - 1] != '*')
            {
                Calcul.Text += button.Text;
                firstnumber = Convert.ToDouble(Resultat.Text);
                Resultat.Text = Convert.ToString(firstnumber - Convert.ToDouble(secondnumber));
                secondnumber = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Calcul.Text[Calcul.Text.Length - 1] != '=' &&
                Calcul.Text[Calcul.Text.Length - 1] != '+' &&
                Calcul.Text[Calcul.Text.Length - 1] != '-' &&
                Calcul.Text[Calcul.Text.Length - 1] != '/' &&
                Calcul.Text[Calcul.Text.Length - 1] != '*')
            {
                Calcul.Text += button.Text;
                firstnumber = Convert.ToDouble(Resultat.Text);
                Resultat.Text = Convert.ToString(firstnumber + Convert.ToDouble(secondnumber));
                secondnumber = "";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Calcul.Text[Calcul.Text.Length - 1] != '=' &&
                Calcul.Text[Calcul.Text.Length - 1] != '+' &&
                Calcul.Text[Calcul.Text.Length - 1] != '-' &&
                Calcul.Text[Calcul.Text.Length - 1] != '/' &&
                Calcul.Text[Calcul.Text.Length - 1] != '*')
            {
                Calcul.Text += button.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Calcul.Text += button.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Calcul.Text += button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;            
            Resultat.Text = (-Convert.ToDouble(Resultat.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Calcul.Text[Calcul.Text.Length - 1] != '=' &&
                Calcul.Text[Calcul.Text.Length - 1] != '+' &&
                Calcul.Text[Calcul.Text.Length - 1] != '-' &&
                Calcul.Text[Calcul.Text.Length - 1] != '/' &&
                Calcul.Text[Calcul.Text.Length - 1] != '*')
            {
                Calcul.Text += button.Text;
                firstnumber = Convert.ToDouble(Resultat.Text);
                Resultat.Text = Convert.ToString(firstnumber / Convert.ToDouble(secondnumber));
                secondnumber = "";
            }
        }

        private void Resultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstnumber = 0;
            secondnumber = "";
            Resultat.Text = "0";
            Calcul.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secondnumber = "0";
            // TODO : faire pour Calcul
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secondnumber = secondnumber.Substring(0, secondnumber.Length - 1);
            Calcul.Text = Calcul.Text.Substring(0, Calcul.Text.Length - 1);
        }
    }
}
