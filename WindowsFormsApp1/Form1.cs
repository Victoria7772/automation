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
    public partial class Form1 : Form
    {
        byte schert = 3;   // счетчик для количества попыток
        byte seconds = 60;   // переменная для определения оставшегося времени до разблокировки
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)   // дублирование полей и очищения полей при создании формы
        {


            txLOG.Text = "";
            txPASS.Text = "";
            erorrM.Text = "";
        }

        private void txLOG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)    // нажатие enter
                txPASS.Focus();                      // получение фокуса строке логина
        }

        private void txPASS_KeyPress(object sender, KeyPressEventArgs e)  // срабатывание при нажатии enter в поле пароль
        {
            if (Convert.ToInt32(e.KeyChar) == 13)   // нажатие enter
            {

                if ((txLOG.Text == "test") && (txPASS.Text == "test"))  // проверка: логин и пароль "test"
                {
                    form2 NextForm = new form2();    //  для перехода
                    NextForm.Show();                 //   на следующую форму
                    schert = 3;  // одновление счетчика
                    erorrM.Text = "";  // очистка поля ошибки, ведь логин пароль верны
                    this.Hide();
                }
                else
                {
                    schert -= 1;   // с каждой неверной попытки уменьшение счетчика попыток
                    erorrM.Text = "Неверно введён логин или пароль" +
                             "\n" + "    Попыток осталось " + schert;  // текст ошибки с выведение количества оставшихся попыток
                    txPASS.Text = "";  // очищение поля пароль
                    if (schert < 1)   // если количество попыток меньше 1, то блокировка
                    {
                        txLOG.Text = "";  // очищаем поле логин (поле пароль очищено выше)
                        txLOG.Enabled = false;
                        txPASS.Enabled = false;
                        ClEnter.Enabled = false;  // блокируем поля и кнопку
                        block.Enabled = true;  // включаем счетчик, считает 1мин и выключает себя и секундный таймер
                        sec.Enabled = true;    // секундный таймер. отсчитывает каждую секунду секунду

                    }
                }
            }
        }

        private void block_Tick(object sender, EventArgs e)  // таймер на 1 мин для включения и выключения блокировки
        {
            
            sec.Enabled = false;      // отключает секундный таймер
            erorrM.Text = "";    // очищает поле ошибки
            txLOG.Enabled = true;       
            txPASS.Enabled = true;
            ClEnter.Enabled = true;  // разблокирывает поля и кнопку
            schert = 3;  // востанавливает кол-во попыток
            seconds = 60;  // востанавливает кол-во времени до разблокировки (на будущее)
            block.Enabled = false;  // выключает секундный таймер 
        }

        private void sec_Tick(object sender, EventArgs e)
        {
            seconds -= 1;   // от переменной отнимаем 1 каждый раз как срабатывает счетчик

            erorrM.Text = "     Превышен лимит попыток" +
                     "\n" + "До разблокировки осталось " + seconds + " сек";  
            // выводим сообщение об ошибке(блокировки) со значением оставшегося времени
        }

        private void ClEnter_Click(object sender, EventArgs e)  // дубликат из txPASS_KeyPress(нажатие enter в поле пароль) для нажатия кнопки ввод
        {
            if ((txLOG.Text == "test") && (txPASS.Text == "test"))
            {
                form2 NextForm = new form2();
                NextForm.Show();
                schert = 3;
                erorrM.Text = "";
            }
            else
            {
                schert -= 1;
                erorrM.Text = "Неверно введён логин или пароль" +
                         "\n" + "    Попыток осталось " + schert;
                txPASS.Text = "";
                if (schert < 1)
                {
                    txLOG.Text = "";
                    txLOG.Enabled = false;
                    txPASS.Enabled = false;
                    ClEnter.Enabled = false;
                    block.Enabled = true;
                    sec.Enabled = true;

                }
            }
        }

        private void xlog_Click(object sender, EventArgs e)
        {

        }

        private void erorrM_Click(object sender, EventArgs e)
        {

        }
    }
}
