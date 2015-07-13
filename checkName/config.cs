using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;


namespace checkName
{
    
    public partial class config : UserControl
    {
        string portConfig;
        string baudConfig;
        string webServiceConfig;
        public config()
        {
            InitializeComponent();
        }

     
       
        private void config_Load(object sender, EventArgs e)
        {
            baudConfig = ConfigurationManager.AppSettings["baud"];
            portConfig = ConfigurationManager.AppSettings["port"];
            webServiceConfig = ConfigurationManager.AppSettings["webService"];
            txbPort.Text = portConfig;
            cmbBaud.SelectedItem = baudConfig;
            txbWebService.Text = webServiceConfig;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["port"].Value = txbPort.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

       
    }
   
}
