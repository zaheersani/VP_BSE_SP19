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
    /// Interaction logic for BindingDemo.xaml
    /// </summary>
    public partial class BindingDemo : Window
    {
        public BindingDemo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //txtItem.Text = ((ListBoxItem)this.listItems.SelectedItem).Content.ToString();
        }

        private void ListItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //txtItem.Text = ((ListBoxItem)this.listItems.SelectedItem).Content.ToString();
        }
    }
}
