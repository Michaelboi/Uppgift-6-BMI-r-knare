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
            Int64.Parse(tbox_input.Text);
        }
        
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnValue_1_Click_1(object sender, RoutedEventArgs e)
        {
            tbox_input.Text = tbox_input.Text + "1";
            
        }

        private void btnValue_2_Click_1(object sender, RoutedEventArgs e)
        {
            tbox_input.Text = tbox_input.Text + "2";
        }
    }
}
