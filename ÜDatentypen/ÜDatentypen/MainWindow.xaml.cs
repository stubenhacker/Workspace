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

namespace ÜDatentypen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int Mx = 0;

        private void cmdAnzeige1_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            Mx = Mx + 1;
            x = x + 1;
            lblAnzeige.Content = "x: " + x + " Mx: " + Mx;
        }

        private void cmdAnzeige2_Click(object sender, RoutedEventArgs e)
        {
            int Mx = 0;
            Mx = Mx + 1;
            lblAnzeige.Content = "Mx: " + Mx; 
        }
    }
}