using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;

namespace checkName
{
    public partial class offline : UserControl
    {
        rfidReader rfid;
        string studentID;
        public offline()
        {
            InitializeComponent();
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        private void offOnline_Load(object sender, EventArgs e)
        {
            int port = Int32.Parse(ConfigurationManager.AppSettings["port"]);
            int baud = Int32.Parse(ConfigurationManager.AppSettings["baud"]);
            rfid = new rfidReader(port, baud);
            
           
        }

        
        // This event handler is where the time-consuming work is done. 
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            rfid.connectDevice();
            BackgroundWorker worker = sender as BackgroundWorker;
            string treturn = "";
            while(true){
               
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    treturn = rfid.searchCard();
                    if (treturn.CompareTo("found") == 0)
                    {
                        worker.ReportProgress(1, "Read");
                       

                        this.rfid.requestCard();


                        studentID = this.rfid.getStudentID();
                        // update textbox in form
                       // if (this.textBox.InvokeRequired)
                       // {
                       //     this.textBox.Invoke(new MethodInvoker(delegate() { this.textBox.Text = this.rfid.getStudentID(); }));
                       // }
                      //  else
                     //   {
                     //       this.textBox.Text = "dfafgdg";
                     //   }
                        
                        break;
                    }
                    // Perform a time consuming operation and report progress.
                   // System.Threading.Thread.Sleep(200);
                    
                    worker.ReportProgress(1,"Wait");
                }
            }

            
        }

        // This event handler updates the progress. 
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string txtReturn;
            txtReturn=e.UserState as String;
            resultLabel.Text = txtReturn;
            //resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            if (txtReturn.CompareTo("Wait")==0)
                resultLabel.ForeColor = Color.Green;
            else
                resultLabel.ForeColor = Color.Chocolate;
        }

        // This event handler deals with the results of the background operation. 
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Stop";
                resultLabel.TextAlign = ContentAlignment.MiddleCenter;
                resultLabel.ForeColor = Color.Red;
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error";
                textBox.AppendText(e.Error.Message);
            }
            else
            {

                if (studentID.CompareTo("fail") != 0)
                {
                    if (!chbAuto.Checked)
                    {
                        DialogResult dialogSaveID = MessageBox.Show("รหัสนักศึกษา : " + studentID, "ยืนยันข้อมูล", MessageBoxButtons.YesNo);
                        if (dialogSaveID == DialogResult.Yes)
                        {
                            textBox.AppendText(studentID + Environment.NewLine);
                        }
                    }
                    else
                    {
                        textBox.AppendText(studentID + Environment.NewLine);
                    }
                }
                resultLabel.Text = "Done";
                resultLabel.ForeColor = Color.PowderBlue;

                System.Threading.Thread.Sleep(1000);
                backgroundWorker1.RunWorkerAsync();
              
            }
        }

        private void btnFileSava_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "เลือกที่เก็บไฟล์";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                txbFileSave.Text = saveFileDialog.FileName;

            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!this.rfid.bConnectedDevice)
            {
                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                    btnStartStop.Text = "STOP";
                }

            }
            else
            {
                if (backgroundWorker1.WorkerSupportsCancellation == true)
                {
                    backgroundWorker1.CancelAsync();
                    btnStartStop.Text = "START";
                    this.rfid.disconnectDevice();
                }

            }
        }

       
    }
}
