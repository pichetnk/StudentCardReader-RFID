namespace checkName
{
    partial class offline
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnFileSava = new System.Windows.Forms.Button();
            this.txbFileSave = new System.Windows.Forms.TextBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.chbAuto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AllowDrop = true;
            this.textBox.Location = new System.Drawing.Point(241, 75);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(308, 297);
            this.textBox.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.resultLabel.ForeColor = System.Drawing.Color.Red;
            this.resultLabel.Location = new System.Drawing.Point(81, 75);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(115, 39);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "STOP";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status :";
            // 
            // btnFileSava
            // 
            this.btnFileSava.Location = new System.Drawing.Point(30, 19);
            this.btnFileSava.Name = "btnFileSava";
            this.btnFileSava.Size = new System.Drawing.Size(94, 32);
            this.btnFileSava.TabIndex = 5;
            this.btnFileSava.Text = "เลือกไฟล์";
            this.btnFileSava.UseVisualStyleBackColor = true;
            this.btnFileSava.Click += new System.EventHandler(this.btnFileSava_Click);
            // 
            // txbFileSave
            // 
            this.txbFileSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txbFileSave.Location = new System.Drawing.Point(130, 24);
            this.txbFileSave.Name = "txbFileSave";
            this.txbFileSave.ReadOnly = true;
            this.txbFileSave.Size = new System.Drawing.Size(296, 22);
            this.txbFileSave.TabIndex = 7;
            this.txbFileSave.TabStop = false;
            this.txbFileSave.Text = "ยังไม่ได้เลือกไฟล์";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStartStop.Location = new System.Drawing.Point(64, 329);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(95, 43);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // chbAuto
            // 
            this.chbAuto.AutoSize = true;
            this.chbAuto.Location = new System.Drawing.Point(30, 124);
            this.chbAuto.Name = "chbAuto";
            this.chbAuto.Size = new System.Drawing.Size(76, 17);
            this.chbAuto.TabIndex = 9;
            this.chbAuto.Text = "Auto Save";
            this.chbAuto.UseVisualStyleBackColor = true;
            // 
            // offline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbAuto);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.txbFileSave);
            this.Controls.Add(this.btnFileSava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Name = "offline";
            this.Size = new System.Drawing.Size(580, 380);
            this.Load += new System.EventHandler(this.offOnline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnFileSava;
        private System.Windows.Forms.TextBox txbFileSave;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.CheckBox chbAuto;
    }
}
