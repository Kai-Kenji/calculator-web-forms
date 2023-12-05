using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaschenRechner_Version_7._1
{
    public partial class Form1 : Form
    {
        List<double>zahlen = new List<double> ();
        List<char>operationen = new List<char> ();

        string zahlAlsZiffer;
        double zahlAlsZahl;
        char rechner;



        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) // 1
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e) // 2
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e) // 3
        {
            textBox1.Text += "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button9_Click(object sender, EventArgs e) // 4
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e) // 5 
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e) // 6
        {
            textBox1.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e) // 7
        {
            textBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e) // 8
        {
            textBox1.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e) // 9
        {
            textBox1.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e) // 0
        {
            textBox1.Text += "0";
        }
        private void button18_Click(object sender, EventArgs e) // Punkt
        {
            textBox1.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e) // +
        {

            zahlAlsZiffer = textBox1.Text;

            textBox1.Text = "+";

            rechner = '+';
            operationen.Add(rechner);


            zahlAlsZahl = double.Parse(zahlAlsZiffer);
            zahlen.Add(zahlAlsZahl);

            zahlAlsZiffer = "";
            zahlAlsZahl = 0;

            textBox1.Text = "";

        }

        private void button8_Click(object sender, EventArgs e) // -
        {
            zahlAlsZiffer = textBox1.Text;

            textBox1.Text = "-";

            rechner = '-';
            operationen.Add(rechner);


            zahlAlsZahl = double.Parse(zahlAlsZiffer);
            zahlen.Add(zahlAlsZahl);

            zahlAlsZiffer = "";
            zahlAlsZahl = 0;

            textBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e) // *
        {
            zahlAlsZiffer = textBox1.Text;

            textBox1.Text = "*";

            rechner = '*';
            operationen.Add(rechner);


            zahlAlsZahl = double.Parse(zahlAlsZiffer);
            zahlen.Add(zahlAlsZahl);

            zahlAlsZiffer = "";
            zahlAlsZahl = 0;

            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) // geteilt durch
        {
            zahlAlsZiffer = textBox1.Text;

            textBox1.Text = "/";

            rechner = '/';
            operationen.Add(rechner);


            zahlAlsZahl = double.Parse(zahlAlsZiffer);
            zahlen.Add(zahlAlsZahl);

            zahlAlsZiffer = "";
            zahlAlsZahl = 0;

            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) // DEL
        {
            textBox1.Text = "";
            zahlAlsZiffer = "";
            zahlAlsZahl = 0;
            rechner = ' '; // mit einem Abstand initialisiert

            zahlen.Clear();
            operationen.Clear();

        }

        private void button16_Click(object sender, EventArgs e) // Enter 
        {
            zahlAlsZiffer = textBox1.Text;
            zahlAlsZahl = double.Parse(zahlAlsZiffer);
            zahlen.Add(zahlAlsZahl);


            double zwischenErgebnis = 0;
            char? rechnerZwischenErgebnis = null;

            if (rechner == '/' && zahlAlsZiffer == "0")
            {
                textBox1.Text = "Error";
                return;
            }


            for (int i = 0; i < zahlen.Count; i++) 
            {
                double zahl = zahlen[i]; // double zahl = Anzeige, welche zahl gerade vom Index (Liste) verarbeitet wird
                char? rechner = null; // 1. Operator zuerst null -- ab 2. durchgang = rechnerZwischenErgebnis

                if (i == zahlen.Count - 1) // letzte Zahl
                {
                    rechner = null;
                }
                else
                {
                    rechner = operationen[i];
                }

                switch ( rechnerZwischenErgebnis) // 2. Operator
                {
                    case '+':
                        zwischenErgebnis += zahl;
                        break;
                    case null:
                        zwischenErgebnis = zahl; // 1. Zahl u. o. Zwischenergebnis
                        break;
                    case '-':
                        zwischenErgebnis -= zahl;
                        break;
                    case '*':
                        zwischenErgebnis *= zahl;
                        break;
                    case '/':
                        zwischenErgebnis /= zahl;
                        break;
                }
                    
               
                rechnerZwischenErgebnis = rechner; // Operator ab 2. durchlauf

            }

            textBox1.Text = zwischenErgebnis.ToString();
            zwischenErgebnis = 0;
            zahlen.Clear();
            operationen.Clear();
            rechnerZwischenErgebnis = null;
            rechner = ' ';
         
             
        }

        private void button4_Click(object sender, EventArgs e) // backslash
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
