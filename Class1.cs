using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Uppgift_6_BMI_räknare;



namespace Miniräknare
{
    
    public class MainValues
    {
        public Double Resultat = 0;
        public string Genomförd = "";
        public bool Genomförd_Status = false;
    }
    
    
    
    public class AllaSiffror : MainValues
    {
        public void Siffror(ref object sender)
        {
            
            if (Genomförd_Status)
                tbox_input.Text = "";
            Genomförd_Status = false;
            Button knapp = (Button)sender;
            tbox_input.Text = tbox_input.Text + knapp.Content;
        }
        
    }
    public class Operatör : MainValues
    {
        public void Operatörer(ref object sender)
        {
            Button knapp = (Button)sender;
            Genomförd = (string)knapp.Content;
            Resultat = Double.Parse(tbox_input.Text);
            Label_Resultat.Content = Resultat + " " + Resultat + Genomförd;
            Genomförd_Status = true;
        }

    }
    public class Resultat_tecken : MainValues
    {
        public void Resultat()
        {
            switch (Genomförd)
            {
                case "+":
                    tbox_input.Text = (Resultat + Double.Parse(tbox_input.Text)).ToString();
                    break;
                case "-":
                    tbox_input.Text = (Resultat - Double.Parse(tbox_input.Text)).ToString();
                    break;
                case "/":
                    tbox_input.Text = (Resultat / Double.Parse(tbox_input.Text)).ToString();
                    break;
                case "*":
                    tbox_input.Text = (Resultat * Double.Parse(tbox_input.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
    public class Clear_CE : MainValues
    {
        public void Clear()
        {
            tbox_input.Text = "";
            Resultat = 0;
            Label_Resultat.Content = "";
        }
    }

}
