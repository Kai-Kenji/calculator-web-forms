using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : Page
{

    List<double> zahlen = new List<double>();
    List<char> operationen = new List<char>();

    string zahlAlsZiffer;
    double zahlAlsZahl;
    char rechner;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void delete_Click(object sender, EventArgs e)
    {
        TextBox1.Text = string.Empty;
        
        zahlen.Clear();
        operationen.Clear();

        zahlAlsZahl = 0;
        zahlAlsZiffer = string.Empty;

        Session["operatoren"] = operationen;
        Session["listeZahlen"] = zahlen;

    }

    protected void geteilt_Click(object sender, EventArgs e) // geteilt
    {
        zahlAlsZiffer = TextBox1.Text;
        zahlAlsZahl = double.Parse(zahlAlsZiffer);
        zahlen = Session["listeZahlen"] as List<double>;
        if (zahlen == null) { zahlen = new List<double>(); }
        zahlen.Add(zahlAlsZahl);

        Session["listeZahlen"] = zahlen;

        TextBox1.Text = "/";
        rechner = '/';
        operationen = (List<char>)Session["operatoren"];
        if (operationen == null) { operationen = new List<char>(); }
        operationen.Add(rechner);

        Session["operatoren"] = operationen;

        zahlAlsZahl = 0;
        zahlAlsZiffer = "";
        TextBox1.Text = "";
    }

    protected void mal_Click(object sender, EventArgs e) // *
    {
        zahlAlsZiffer = TextBox1.Text;
        zahlAlsZahl = double.Parse(zahlAlsZiffer);
        zahlen = Session["listeZahlen"] as List<double>;
        if (zahlen == null) { zahlen = new List<double>(); }
        zahlen.Add(zahlAlsZahl);

        Session["listeZahlen"] = zahlen;

        TextBox1.Text = "*";
        rechner = '*';
        operationen = (List<char>)Session["operatoren"];
        if (operationen == null) { operationen = new List<char>(); }
        operationen.Add(rechner);

        Session["operatoren"] = operationen;

        zahlAlsZahl = 0;
        zahlAlsZiffer = "";
        TextBox1.Text = "";
    }

    protected void minus_Click(object sender, EventArgs e) // -
    {
        zahlAlsZiffer = TextBox1.Text;
        zahlAlsZahl = double.Parse(zahlAlsZiffer);
        zahlen = Session["listeZahlen"] as List<double>;
        if (zahlen == null) { zahlen = new List<double>(); }
        zahlen.Add(zahlAlsZahl);

        Session["listeZahlen"] = zahlen;

        TextBox1.Text = "-";
        rechner = '-';
        operationen = (List<char>)Session["operatoren"];
        if (operationen == null) { operationen = new List<char>(); }
        operationen.Add(rechner);

        Session["operatoren"] = operationen;

        zahlAlsZahl = 0;
        zahlAlsZiffer = "";
        TextBox1.Text = "";
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "7";
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "8";
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "9";
    }

    protected void plus_Click(object sender, EventArgs e) // +
    {
        zahlAlsZiffer = TextBox1.Text;
        zahlAlsZahl = double.Parse(zahlAlsZiffer);
        zahlen = Session["listeZahlen"] as List<double>;
        if (zahlen == null) { zahlen = new List<double>(); }  // dass die Variable zahlen immer auf eine gültige Liste von Dezimalzahlen verweist, entweder durch das Abrufen der Liste aus der Session oder durch das Erstellen einer neuen leeren Liste
        zahlen.Add(zahlAlsZahl);

        Session["listeZahlen"] = zahlen;

        TextBox1.Text = "+";
        rechner = '+';
        operationen = (List<char>)Session["operatoren"];
        if (operationen == null) { operationen = new List<char>(); }
        operationen.Add(rechner);

        Session["operatoren"] = operationen;

        zahlAlsZahl = 0;
        zahlAlsZiffer = "";
        TextBox1.Text = "";

    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "4";
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "5";
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "6";
    }

    protected void backslash_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Length > 0)
        {
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1);
        }
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "1";
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "2";
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "3";
    }

    protected void enter_Click(object sender, EventArgs e) // enter
    {
        zahlAlsZiffer = TextBox1.Text;
        zahlAlsZahl = double.Parse(zahlAlsZiffer);
        zahlen.Add(zahlAlsZahl);

        var testzahl = Session["listeZahlen"] as List<double>;

        testzahl.Add(zahlAlsZahl);

        Session["listeZahlen"] = testzahl;



        List<double> zahlenListe = (List<double>)Session["listeZahlen"];
        List<char> operatoren = (List<char>)Session["operatoren"];

       

        double zwischenErgebnis = zahlenListe[0];
        char? rechnerZwischenErgebnis = null;

        for (int i = 0; i < zahlenListe.Count; i++)
        {
            double zahl = zahlenListe[i];
            char? rechner = null;

            if (i == zahlenListe.Count - 1)
            {
                rechner = null;
            }
            else
            {
                rechner = operatoren[i];
            }
            

            if (rechner == '/' && zahlAlsZiffer == "0")
            {
                TextBox1.Text = "Error";
                return;
            }

            switch (rechnerZwischenErgebnis)
            {
                case '+':
                    zwischenErgebnis += zahl;
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


            rechnerZwischenErgebnis = rechner;



        }


        TextBox1.Text = zwischenErgebnis.ToString();
        zwischenErgebnis = 0;
        zahlen.Clear();
        zahlenListe.Clear();
        operationen.Clear();
        operatoren.Clear();
        rechnerZwischenErgebnis = null;
        rechner = ' ';


    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "0";
    }

    protected void punkt_Click(object sender, EventArgs e)
    {
        TextBox1.Text += ".";
    }
}