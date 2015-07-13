namespace checkName
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOnline = new System.Windows.Forms.ToolStripButton();
            this.tsbOffline = new System.Windows.Forms.ToolStripButton();
            this.tsbReadCard = new System.Windows.Forms.ToolStripButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tsbConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOnline,
            this.tsbOffline,
            this.tsbReadCard,
            this.tsbConfig});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOnline
            // 
            this.tsbOnline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOnline.Image = ((System.Drawing.Image)(resources.GetObject("tsbOnline.Image")));
            this.tsbOnline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOnline.Name = "tsbOnline";
            this.tsbOnline.Size = new System.Drawing.Size(104, 22);
            this.tsbOnline.Text = "บันทึกข้อมูล Online";
            this.tsbOnline.Click += new System.EventHandler(this.tsbOnline_Click);
            // 
            // tsbOffline
            // 
            this.tsbOffline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOffline.Image = ((System.Drawing.Image)(resources.GetObject("tsbOffline.Image")));
            this.tsbOffline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOffline.Name = "tsbOffline";
            this.tsbOffline.Size = new System.Drawing.Size(105, 22);
            this.tsbOffline.Text = "บันทึกข้อมูล Offline";
            this.tsbOffline.Click += new System.EventHandler(this.tsbOffonline_Click);
            // 
            // tsbReadCard
            // 
            this.tsbReadCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReadCard.Image = ((System.Drawing.Image)(resources.GetObject("tsbReadCard.Image")));
            this.tsbReadCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReadCard.Name = "tsbReadCard";
            this.tsbReadCard.Size = new System.Drawing.Size(70, 22);
            this.tsbReadCard.Text = "ข้อมูลทั้งหมด";
            this.tsbReadCard.Click += new System.EventHandler(this.tsbReadCard_Click_1);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(584, 415);
            this.mainPanel.TabIndex = 2;
            // 
            // tsbConfig
            // 
            this.tsbConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfig.Image")));
            this.tsbConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfig.Name = "tsbConfig";
            this.tsbConfig.Size = new System.Drawing.Size(35, 22);
            this.tsbConfig.Text = "ตั้งค่า";
            this.tsbConfig.Click += new System.EventHandler(this.tsbConfig_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบบันทึกข้อมูลกิจกรรม";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbReadCard;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripButton tsbOffline;
        private System.Windows.Forms.ToolStripButton tsbOnline;
        private System.Windows.Forms.ToolStripButton tsbConfig;

    }
}

