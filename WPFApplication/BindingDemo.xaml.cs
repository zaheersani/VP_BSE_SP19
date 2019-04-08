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

using FirstConsoleApp;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for BindingDemo.xaml
    /// </summary>
    public partial class BindingDemo : Window
    {
        PhoneBook pb; 
        public BindingDemo()
        {
            InitializeComponent();

            pb = new PhoneBook();

            pb.AddContact(new Contact()
            {
                Name = "Contac1",
                Number = "Num1"
            });
            pb.AddContact(new Contact()
            {
                Name = "Contac2",
                Number = "Num2"
            });

            this.listItems.ItemsSource = pb.GetAllContacts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //txtItem.Text = ((ListBoxItem)this.listItems.SelectedItem).Content.ToString();
            foreach (Contact item in pb.GetAllContacts())
            {
                Console.WriteLine(item.Name);
            }
        }

        private void ListItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //txtItem.Text = ((ListBoxItem)this.listItems.SelectedItem).Content.ToString();
        }
    }
}
