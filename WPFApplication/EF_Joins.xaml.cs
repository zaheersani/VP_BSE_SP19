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
    /// Interaction logic for EF_Joins.xaml
    /// </summary>
    public partial class EF_Joins : Window
    {
        public EF_Joins()
        {
            InitializeComponent();

            HospitalDBEntities db = new HospitalDBEntities();

            var r = from a in db.Appointments
                    select new
                    {
                       AppID = a.Id,
                       DoctorID = a.dID,
                       a.Doctor.Name,
                       a.Doctor.Specialization,
                       a.AppointmentDate
                    };

            this.dataGridAppointments.ItemsSource = r.ToList();

        }
    }
}
