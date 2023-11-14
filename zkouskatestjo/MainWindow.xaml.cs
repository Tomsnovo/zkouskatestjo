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

namespace zkouskatestjo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double x1;
        double x2;
        double D;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void count(double a, double b, double c )
        {
                D = ((b*b)-(4.0*a*c));
                x1 = -b + Math.Sqrt(D);
                x1 = x1 / (2.0 * a);
                x2 = (-b - (Math.Sqrt(D))) / (2.0 * a); 
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            count(double.Parse(txtboxA.Text), double.Parse(txtboxB.Text), double.Parse(txtboxC.Text));
            txtblock1.Text = "x1 =" + x1;
            txtblock2.Text = "x2 =" + x2;
        }
    }
}
