using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Configuration;

namespace checkName
{
    public partial class online : UserControl
    {
        string studentID;
        rfidReader rfid;

        public online()
        {
            InitializeComponent();
            bgWorkOnline.DoWork += new DoWorkEventHandler(bgWorkOnline_DoWork);
            bgWorkOnline.ProgressChanged +=  new ProgressChangedEventHandler(bgWorkOnline_ProgressChanged);
            bgWorkOnline.RunWorkerCompleted +=   new RunWorkerCompletedEventHandler(bgWorkOnline_RunWorkerCompleted);
        }

       

        private void online_Load(object sender, EventArgs e)
        {
            int port = Int16.Parse(ConfigurationManager.AppSettings["port"]);
            int baud = Int16.Parse(ConfigurationManager.AppSettings["baud"]);
            rfid = new rfidReader(port, baud);
           string postData="studentID=1234325&activityID=1";
                   
                       string returnText=ConnWebService(postData);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!this.rfid.bConnectedDevice)
            {
                if (bgWorkOnline.IsBusy != true)
                {
                    bgWorkOnline.RunWorkerAsync();
                    btnStartStop.Text = "STOP";
                }

            }
            else
            {
                if (bgWorkOnline.WorkerSupportsCancellation == true)
                {
                    bgWorkOnline.CancelAsync();
                    btnStartStop.Text = "START";
                    this.rfid.disconnectDevice();
                }

            }
        }

        // This event handler is where the time-consuming work is done. 
        private void bgWorkOnline_DoWork(object sender, DoWorkEventArgs e)
        {
            rfid.connectDevice();
            BackgroundWorker worker1 = sender as BackgroundWorker;
            string treturn = "";
            while (true)
            {

                if (worker1.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    treturn = rfid.searchCard();
                    if (treturn.CompareTo("found") == 0)
                    {
                        worker1.ReportProgress(1, "Read");
                        this.rfid.requestCard();
                        studentID = this.rfid.getStudentID();
                       
                        break;
                    }
                    // Perform a time consuming operation and report progress.
                    // System.Threading.Thread.Sleep(200);

                    worker1.ReportProgress(2,"Wait");
                }
            }

        }

          // This event handler updates the progress. 
        private void bgWorkOnline_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            string txtReturn;
            txtReturn = e.UserState as String;
            resultLabel.Text = txtReturn;
          
            if (txtReturn.CompareTo("Wait") == 0)
                resultLabel.ForeColor = Color.Green;
            else
                resultLabel.ForeColor = Color.Chocolate;
        }


         // This event handler deals with the results of the background operation. 
        private void bgWorkOnline_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Stop";
                resultLabel.TextAlign = ContentAlignment.MiddleCenter;
                resultLabel.ForeColor = Color.Red;
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {

                if (studentID.CompareTo("fail") != 0)
                {
                    string postData="studentID="+studentID+"&activityID=1";
                    if (!chbAuto.Checked)
                    {
                        DialogResult dialogSaveID = MessageBox.Show("รหัสนักศึกษา : " + studentID, "ยืนยันข้อมูล", MessageBoxButtons.YesNo);
                        if (dialogSaveID == DialogResult.Yes)
                        {
                            string returnText=ConnWebService(postData);
                            textBox.AppendText(studentID + "   ::  " + returnText + Environment.NewLine);
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
                bgWorkOnline.RunWorkerAsync();

            }

        }
        public string ConnWebService(string dataPost)
        {
            string web = ConfigurationManager.AppSettings["webService"];
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = Encoding.ASCII.GetBytes(dataPost);
            //string postData = "User=1234&Pass=GIN";
            //byte[] data = encoding.GetBytes(postData);

            // Prepare web request...

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(web + "studentCard.php");
            myHttpWebRequest.Method = "POST";

            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = data.Length;

            Stream requestStream = myHttpWebRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            Stream responseStream = myHttpWebResponse.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

            string dataReturn = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            responseStream.Close();
            myHttpWebResponse.Close();

            return dataReturn;
        }

      
    }


    
}
