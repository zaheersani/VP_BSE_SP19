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
using System.Windows.Shapes;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for CalculatorDemo.xaml
    /// </summary>
    public partial class CalculatorDemo : Window
    {
        public CalculatorDemo()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(((Button)sender).Content.ToString());
            string num = ((Button)sender).Content.ToString();
            if (this.lblNum.Content.ToString() == "0")
            {
                this.lblNum.Content = "";
            }
            this.lblNum.Content += num;
        }
    }
}
