namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xEnter = new System.Windows.Forms.Label();
            this.ClEnter = new System.Windows.Forms.Button();
            this.txLOG = new System.Windows.Forms.TextBox();
            this.txPASS = new System.Windows.Forms.TextBox();
            this.xlog = new System.Windows.Forms.Label();
            this.xPass = new System.Windows.Forms.Label();
            this.erorrM = new System.Windows.Forms.Label();
            this.block = new System.Windows.Forms.Timer(this.components);
            this.sec = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // xEnter
            // 
            this.xEnter.AutoSize = true;
            this.xEnter.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xEnter.Location = new System.Drawing.Point(105, 9);
            this.xEnter.Name = "xEnter";
            this.xEnter.Size = new System.Drawing.Size(125, 55);
            this.xEnter.TabIndex = 0;
            this.xEnter.Text = "Вход";
            // 
            // ClEnter
            // 
            this.ClEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClEnter.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClEnter.Location = new System.Drawing.Point(115, 291);
            this.ClEnter.Name = "ClEnter";
            this.ClEnter.Size = new System.Drawing.Size(115, 38);
            this.ClEnter.TabIndex = 1;
            this.ClEnter.Text = "Ввод";
            this.ClEnter.UseVisualStyleBackColor = false;
            this.ClEnter.Click += new System.EventHandler(this.ClEnter_Click);
            // 
            // txLOG
            // 
            this.txLOG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txLOG.Location = new System.Drawing.Point(185, 112);
            this.txLOG.Name = "txLOG";
            this.txLOG.Size = new System.Drawing.Size(100, 26);
            this.txLOG.TabIndex = 2;
            this.txLOG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txLOG_KeyPress);
            // 
            // txPASS
            // 
            this.txPASS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txPASS.Location = new System.Drawing.Point(185, 160);
            this.txPASS.Name = "txPASS";
            this.txPASS.PasswordChar = '*';
            this.txPASS.Size = new System.Drawing.Size(100, 26);
            this.txPASS.TabIndex = 3;
            this.txPASS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPASS_KeyPress);
            // 
            // xlog
            // 
            this.xlog.AutoSize = true;
            this.xlog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xlog.Location = new System.Drawing.Point(62, 112);
            this.xlog.Name = "xlog";
            this.xlog.Size = new System.Drawing.Size(61, 21);
            this.xlog.TabIndex = 4;
            this.xlog.Text = "Логин";
            this.xlog.Click += new System.EventHandler(this.xlog_Click);
            // 
            // xPass
            // 
            this.xPass.AutoSize = true;
            this.xPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xPass.Location = new System.Drawing.Point(62, 160);
            this.xPass.Name = "xPass";
            this.xPass.Size = new System.Drawing.Size(69, 21);
            this.xPass.TabIndex = 5;
            this.xPass.Text = "Пароль";
            // 
            // erorrM
            // 
            this.erorrM.AutoSize = true;
            this.erorrM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erorrM.ForeColor = System.Drawing.Color.Red;
            this.erorrM.Location = new System.Drawing.Point(63, 228);
            this.erorrM.Name = "erorrM";
            this.erorrM.Size = new System.Drawing.Size(230, 17);
            this.erorrM.TabIndex = 6;
            this.erorrM.Text = "Неверно введен логин или пароль";
            this.erorrM.Click += new System.EventHandler(this.erorrM_Click);
            // 
            // block
            // 
            this.block.Interval = 60000;
            this.block.Tick += new System.EventHandler(this.block_Tick);
            // 
            // sec
            // 
            this.sec.Interval = 1000;
            this.sec.Tick += new System.EventHandler(this.sec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(349, 377);
            this.Controls.Add(this.erorrM);
            this.Controls.Add(this.xPass);
            this.Controls.Add(this.xlog);
            this.Controls.Add(this.txPASS);
            this.Controls.Add(this.txLOG);
            this.Controls.Add(this.ClEnter);
            this.Controls.Add(this.xEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xEnter;
        private System.Windows.Forms.Button ClEnter;
        private System.Windows.Forms.TextBox txLOG;
        private System.Windows.Forms.TextBox txPASS;
        private System.Windows.Forms.Label xlog;
        private System.Windows.Forms.Label xPass;
        private System.Windows.Forms.Label erorrM;
        private System.Windows.Forms.Timer block;
        private System.Windows.Forms.Timer sec;
    }
}

