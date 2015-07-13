namespace checkName
{
    partial class online
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartStop = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labWebServic = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.bgWorkOnline = new System.ComponentModel.BackgroundWorker();
            this.chbAuto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(85, 309);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(115, 39);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.resultLabel.ForeColor = System.Drawing.Color.Red;
            this.resultLabel.Location = new System.Drawing.Point(121, 61);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(124, 42);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "STOP";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status :";
            // 
            // labWebServic
            // 
            this.labWebServic.AutoSize = true;
            this.labWebServic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labWebServic.ForeColor = System.Drawing.Color.DarkGreen;
            this.labWebServic.Location = new System.Drawing.Point(467, 22);
            this.labWebServic.Name = "labWebServic";
            this.labWebServic.Size = new System.Drawing.Size(76, 20);
            this.labWebServic.TabIndex = 7;
            this.labWebServic.Text = "Connect";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(295, 61);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(260, 287);
            this.textBox.TabIndex = 8;
            // 
            // bgWorkOnline
            // 
            this.bgWorkOnline.WorkerReportsProgress = true;
            this.bgWorkOnline.WorkerSupportsCancellation = true;
            // 
            // chbAuto
            // 
            this.chbAuto.AutoSize = true;
            this.chbAuto.Location = new System.Drawing.Point(58, 112);
            this.chbAuto.Name = "chbAuto";
            this.chbAuto.Size = new System.Drawing.Size(76, 17);
            this.chbAuto.TabIndex = 9;
            this.chbAuto.Text = "Auto Save";
            this.chbAuto.UseVisualStyleBackColor = true;
            // 
            // online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbAuto);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labWebServic);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartStop);
            this.Name = "online";
            this.Size = new System.Drawing.Size(580, 380);
            this.Load += new System.EventHandler(this.online_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labWebServic;
        private System.Windows.Forms.TextBox textBox;
        private System.ComponentModel.BackgroundWorker bgWorkOnline;
        private System.Windows.Forms.CheckBox chbAuto;
    }
}
