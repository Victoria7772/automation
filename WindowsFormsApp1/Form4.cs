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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void archiveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.archiveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Archive". При необходимости она может быть перемещена или удалена.
            this.archiveTableAdapter.Fill(this.testDataSet.Archive);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 NextForm = new Form3();
            NextForm.Show();
            this.Close();  // всместо this.Close(); можно писать this.Hide(); - так как можно вернуть значение this.Show();
        }
    }
}
