namespace checkName
{
    partial class cardData
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
            this.txbNameTH = new System.Windows.Forms.TextBox();
            this.txbLNameTH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbStuID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIDCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNameTH
            // 
            this.txbNameTH.Location = new System.Drawing.Point(136, 112);
            this.txbNameTH.Name = "txbNameTH";
            this.txbNameTH.Size = new System.Drawing.Size(153, 20);
            this.txbNameTH.TabIndex = 0;
            // 
            // txbLNameTH
            // 
            this.txbLNameTH.Location = new System.Drawing.Point(136, 138);
            this.txbLNameTH.Name = "txbLNameTH";
            this.txbLNameTH.Size = new System.Drawing.Size(153, 20);
            this.txbLNameTH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "นามสกุล :";
            // 
            // txbStuID
            // 
            this.txbStuID.Location = new System.Drawing.Point(136, 54);
            this.txbStuID.Name = "txbStuID";
            this.txbStuID.Size = new System.Drawing.Size(117, 20);
            this.txbStuID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "รหัสนักศึกษา :";
            // 
            // txbIDCard
            // 
            this.txbIDCard.Location = new System.Drawing.Point(136, 80);
            this.txbIDCard.Name = "txbIDCard";
            this.txbIDCard.Size = new System.Drawing.Size(143, 20);
            this.txbIDCard.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "รหัสบัตรประชาชน :";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(263, 191);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "อ่านข้อมูล";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cardData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIDCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbStuID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLNameTH);
            this.Controls.Add(this.txbNameTH);
            this.Name = "cardData";
            this.Size = new System.Drawing.Size(398, 258);
            this.Load += new System.EventHandler(this.cardData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNameTH;
        private System.Windows.Forms.TextBox txbLNameTH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbStuID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIDCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRead;

    }
}
