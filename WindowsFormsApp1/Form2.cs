using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class form2 : Form
    {

        byte ch;
        Random rand = new Random();
        int a;
       
        public form2()
        {
            InitializeComponent();
        }

        private void SMSRnd_Click(object sender, EventArgs e)
        {
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if ( SMSRnd.Text == number.Text)
                {
                    Form3 NextForm = new Form3();
                    NextForm.Show();
                    this.Close();  // всместо this.Close(); можно писать this.Hide(); - так как можно вернуть значение this.Show();
                }
                else
                {
                    ch -= 1;
                    erorrSMS.Text = "Неверно веденное SMS" +
                             "\n" + "   попыток осталось " + ch;
                    number.Text = "";
                    if (ch < 1)
                    {
                        number.Enabled = false;
                        enterSMS.Enabled = false;
                        timerExit.Enabled = true;
                    }
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timerExit.Enabled = false;
            number.Enabled = true;
            enterSMS.Enabled = true;
            a = rand.Next(1000, 9999);
            SMSRnd.Text = Convert.ToString(a);
            ch = 3;
            erorrSMS.Text = "";
        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterSMS_Click(object sender, EventArgs e)
        {
            if (SMSRnd.Text == number.Text)
            {
                Form3 NextForm = new Form3();
                NextForm.Show();
                this.Close();  // всместо this.Close(); можно писать this.Hide(); - так как можно вернуть значение this.Show();
            }
            else
            {
                ch -= 1;
                erorrSMS.Text = "Неверно веденное SMS" +
                         "\n" + "   попыток осталось " + ch;
                number.Text = "";
                if (ch < 1)
                {
                    number.Enabled = false;
                    enterSMS.Enabled = false;
                    timerExit.Enabled = true;
                    Form1 NextForm = new Form1();
                    NextForm.Show();
                    this.Close();  // всместо this.Close(); можно писать this.Hide(); - так как можно вернуть значение this.Show();
                }
            }
        }
    }
}
