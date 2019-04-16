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

using Microsoft.Win32;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for DebuggingAndMenus.xaml
    /// </summary>
    public partial class DebuggingAndMenus : Window
    {
        List<string> names; 
        public DebuggingAndMenus()
        {
            InitializeComponent();
            names = new List<string>()
            {
                "Ali", "Ahmed", "Salman", "Zafar"
            };
        }

        private void BtnDebug_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].ToLower().StartsWith("a"))
                {
                    this.listBoxNames.Items.Add(names[i]);
                    //this.names.Add(names[i]);
                }
                else
                    this.listBoxNames.Items.Remove(names[i]);
            }
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
        }
    }
}
