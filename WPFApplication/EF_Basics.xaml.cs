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
    /// Interaction logic for EF_Basics.xaml
    /// </summary>
    public partial class EF_Basics : Window
    {
        public EF_Basics()
        {
            InitializeComponent();

            this.ShowDoctors();
        }

        private void ShowDoctors()
        {
            HospitalDBEntities db = new HospitalDBEntities();
            this.dataGridDocs.ItemsSource = db.Doctors.ToList();

            var r = from d in db.Doctors
                    where d.Name.EndsWith("Ali")
                    select d;

            foreach (var item in r)
            {
                Console.WriteLine(item.Name);
            }

            //this.dataGridDocs.ItemsSource = r.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            HospitalDBEntities db = new HospitalDBEntities();

            // TODO: Replace hard coded values with Text Inputs
            db.Doctors.Add(new Doctor()
            {
                Name = "New Doc",
                Specialization = "New Spec"
            });

            db.SaveChanges();

            MessageBox.Show("New Record added!");

            this.dataGridDocs.ItemsSource = db.Doctors.ToList();
        }
    }
}
