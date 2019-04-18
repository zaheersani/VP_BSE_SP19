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

using System.ComponentModel;

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for BackgroundWorkerDemo.xaml
    /// </summary>
    public partial class BackgroundWorkerDemo : Window
    {
        BackgroundWorker bgWorker = new BackgroundWorker();
        public BackgroundWorkerDemo()
        {
            InitializeComponent();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;

            // TODO: Start, Pause, Resume States
            // TODO: Cancel/Stop Button
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Cancelled!");
            else
            {
                MessageBox.Show("Done!");
                i = 1;
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lblCounter.Content = e.ProgressPercentage;
        }

        private int i = 1;
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for ( ; i <= 50; i++)
            {
                System.Threading.Thread.Sleep(100);
                this.bgWorker.ReportProgress(i);
                if(this.bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                this.bgWorker.RunWorkerAsync();
                this.btnStart.Content = "Stop";
            }
            else
            {
                bgWorker.CancelAsync();
                this.btnStart.Content = "Start";
            }
        }
    }
}
