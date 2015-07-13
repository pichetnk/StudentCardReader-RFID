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
    public partial class cardData : UserControl
    {
        rfidReader rfid;
        
       

        public cardData()
        {
            InitializeComponent();
        }

        private void cardData_Load(object sender, EventArgs e)
        {
            int port = Int16.Parse(ConfigurationManager.AppSettings["port"]);
            int baud = Int16.Parse(ConfigurationManager.AppSettings["baud"]);
            rfid = new rfidReader(port, baud);
           
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
                this.rfid.connectDevice();
                this.rfid.requestCard();
                txbIDCard.Text = this.rfid.getIDCard();
                txbStuID.Text = this.rfid.getStudentID();
                //Thread.Sleep(1000);
           
                txbNameTH.Text = this.rfid.getStudentNameTH();
                txbLNameTH.Text = this.rfid.getStudentLNameTH();
        }
         
    }
}
