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

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            this.lblSample.Content = ((Button)sender).Content;
            //Console.WriteLine("Button Clicked!");
            //this.btnClick.Content = "I am clicked!";
            //this.lblSample.Content = this.btnClick.Content;
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            if (!int.TryParse(this.txtNum1.Text, out n1)) {
                this.txtNum1.Focus();
                this.txtNum1.SelectAll();
                MessageBox.Show("Invalid Input");
            }
            if (!int.TryParse(this.txtNum2.Text, out n2))
            {
                this.txtNum2.Focus();
                this.txtNum2.SelectAll();
                MessageBox.Show("Invalid Input");
            }
            if ( ((Button)sender).Content.ToString() == "+")
                this.lblResult.Content = (n1 + n2).ToString();
            if (((Button)sender).Content.ToString() == "-")
                this.lblResult.Content = (n1 - n2).ToString();
        }
    }
}
