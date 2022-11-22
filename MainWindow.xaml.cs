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
        
        
        public MainWindow()

        {
            InitializeComponent();

            tbox_input.Text = "";
        }
        

        AllaSiffror Siffra = new AllaSiffror();
        Operatör Tecken = new Operatör();
        Resultat_tecken LikaMed = new Resultat_tecken();
        Clear_CE ClearKnapp = new Clear_CE();
        public void btnValue_Click(object sender, RoutedEventArgs e)
        {
            // Den här funktionen är kopplad till operatörerna och rensar textbox fältet efter man knappat in en operatör
            // Den tar också själva symbolen på knappen och lägger till den i textbox fältet hela tiden.
            Siffra.Siffror(ref sender);
        }
        public void btnResultat_Click(object sender, RoutedEventArgs e)
        {
            // den här funktionen använder switch för att kunna kolla vilket tecken som används
            // därefter tar den det första värdet man skriver in och sen en operatör mellan och sen nästa input man skriver in
            LikaMed.Resultat();

        }
        public void btnOperatör_Click(object sender, RoutedEventArgs e)
        {
            // den här funktionen gör att operatörernas funktion kan genomföras och skriver också in i labeln vilket tecken som används och värdet innan man valt
            Tecken.Operatörer(ref sender);
        }

        public void btnClear_Click(object sender, RoutedEventArgs e)
            // den här funktionen rensar alla värden så det blir 0 eller tomt beroende på datatyp.
        {
            ClearKnapp.Clear();
        }
        // den här funktionen behövs för textbox
        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
