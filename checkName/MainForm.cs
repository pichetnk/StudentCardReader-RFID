using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;//

namespace checkName
{
    public partial class MainForm : Form
    {
        UserControl cData;
        UserControl offline;
       // UserControl online;
        UserControl config;

        [DllImport("MasterRD.dll")]
        static extern int rf_init_com(int port, int baud);

        public MainForm()
        {
            InitializeComponent();
        }
          private void MainForm_Load(object sender, EventArgs e)
        {
            

            cData = new cardData();
            mainPanel.Controls.Add(cData);
            cData.Visible = false;

            offline = new offline();
            mainPanel.Controls.Add(offline);
            offline.Visible = false;
            
           // online = new online();
            //mainPanel.Controls.Add(online);
            //online.Visible = false;

            config = new config();
            mainPanel.Controls.Add(config);
            config.Visible = false;
        }
       

        private void tsbReadCard_Click_1(object sender, EventArgs e)
        {
            cData.Visible = true;
            offline.Visible = false;
            //online.Visible = false;
            config.Visible = false;
        }

        private void tsbOffonline_Click(object sender, EventArgs e)
        {
           
            //offline.Visible=true;
           // cData.Visible = false;
           // online.Visible = false;
            //config.Visible = false;
        }

        private void tsbOnline_Click(object sender, EventArgs e)
        {
           // online.Visible = true;
            offline.Visible = false;
            cData.Visible = false;
            config.Visible = false;
        }

        private void tsbConfig_Click(object sender, EventArgs e)
        {
            //online.Visible = false;
            offline.Visible = false;
            cData.Visible = false;
            config.Visible = true;
        }

      

      

      
    }
}
