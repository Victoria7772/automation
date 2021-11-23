namespace WindowsFormsApp1
{
    partial class form2
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
            this.components = new System.ComponentModel.Container();
            this.xSMS = new System.Windows.Forms.Label();
            this.SMSRnd = new System.Windows.Forms.Label();
            this.erorrSMS = new System.Windows.Forms.Label();
            this.enterSMS = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.timerExit = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // xSMS
            // 
            this.xSMS.AutoSize = true;
            this.xSMS.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xSMS.Location = new System.Drawing.Point(31, 18);
            this.xSMS.Name = "xSMS";
            this.xSMS.Size = new System.Drawing.Size(352, 42);
            this.xSMS.TabIndex = 0;
            this.xSMS.Text = "Введите код из SMS\r\n";
            // 
            // SMSRnd
            // 
            this.SMSRnd.AutoSize = true;
            this.SMSRnd.BackColor = System.Drawing.Color.Aqua;
            this.SMSRnd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMSRnd.Location = new System.Drawing.Point(169, 89);
            this.SMSRnd.Name = "SMSRnd";
            this.SMSRnd.Size = new System.Drawing.Size(60, 27);
            this.SMSRnd.TabIndex = 1;
            this.SMSRnd.Text = "1234";
            this.SMSRnd.Click += new System.EventHandler(this.SMSRnd_Click);
            // 
            // erorrSMS
            // 
            this.erorrSMS.AutoSize = true;
            this.erorrSMS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorrSMS.ForeColor = System.Drawing.Color.Red;
            this.erorrSMS.Location = new System.Drawing.Point(123, 173);
            this.erorrSMS.Name = "erorrSMS";
            this.erorrSMS.Size = new System.Drawing.Size(161, 17);
            this.erorrSMS.TabIndex = 2;
            this.erorrSMS.Text = "Неверно веденное SMS";
            // 
            // enterSMS
            // 
            this.enterSMS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterSMS.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterSMS.Location = new System.Drawing.Point(155, 328);
            this.enterSMS.Name = "enterSMS";
            this.enterSMS.Size = new System.Drawing.Size(100, 51);
            this.enterSMS.TabIndex = 3;
            this.enterSMS.Text = "Ввод";
            this.enterSMS.UseVisualStyleBackColor = false;
            this.enterSMS.Click += new System.EventHandler(this.enterSMS_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(174, 265);
            this.number.MaxLength = 4;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(55, 29);
            this.number.TabIndex = 4;
            this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // timerExit
            // 
            this.timerExit.Interval = 1500;
            this.timerExit.Tick += new System.EventHandler(this.timerExit_Tick);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.Controls.Add(this.number);
            this.Controls.Add(this.enterSMS);
            this.Controls.Add(this.erorrSMS);
            this.Controls.Add(this.SMSRnd);
            this.Controls.Add(this.xSMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xSMS;
        private System.Windows.Forms.Label SMSRnd;
        private System.Windows.Forms.Label erorrSMS;
        private System.Windows.Forms.Button enterSMS;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Timer timerExit;
    }
}