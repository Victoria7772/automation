using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 NextForm = new Form1();
            NextForm.Show();
            this.Close();  // всместо this.Close(); можно писать this.Hide(); - так как можно вернуть значение this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 NextForm = new Form4();
            NextForm.Show();
            this.Close();  // всместо this.Close(); можно писать this.Hide(); - так как можно вернуть значение this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 NextForm = new Form5();
            NextForm.Show();
            this.Close();  // всместо this.Close(); можно писать this.Hide(); - так как можно вернуть значение this.Show();
        }
    }
}
