using System;
using System.Collections.Generic;
using System.Linq;
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
using Miniräknare;

namespace Uppgift_6_BMI_räknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double Resultat = 0;
        string Genomförd = "";
        bool Genomförd_Status = false;
        
        public MainWindow()

        {
            InitializeComponent();
            
            tbox_input.Text = "";
        }
        
        private void btnValue_Click(object sender, RoutedEventArgs e)
        {
            if (Genomförd_Status)
                tbox_input.Clear();
            Genomförd_Status = false;
            Button knapp = (Button)sender;
            tbox_input.Text = tbox_input.Text + knapp.Content;
        }
        private void btnResultat_Click(object sender, RoutedEventArgs e)
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
        private void btnOperatör_Click(object sender, RoutedEventArgs e)
        {
            Button knapp = (Button)sender;
            Genomförd = (string)knapp.Content;
            Resultat = Double.Parse(tbox_input.Text);
            Label_Resultat.Content = Resultat + " " + Genomförd;
            Genomförd_Status = true;
        }
        public void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbox_input.Text = "";
            Resultat = 0;
            Label_Resultat.Content = "";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
