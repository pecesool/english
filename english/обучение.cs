using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace english
{
    public partial class обучение : Form
    {
        public обучение()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "one") { groupBox1.BackColor = Color.Green; groupBox2.Visible = true; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "two") { groupBox2.BackColor = Color.Green; groupBox3.Visible = true; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "three") { groupBox3.BackColor = Color.Green; groupBox4.Visible = true; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "four") { groupBox4.BackColor = Color.Green; groupBox5.Visible = true; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "five") { groupBox5.BackColor = Color.Green; groupBox6.Visible = true; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "six") { groupBox6.BackColor = Color.Green; groupBox7.Visible = true; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "seven") { groupBox7.BackColor = Color.Green; groupBox8.Visible = true; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "eight") { groupBox8.BackColor = Color.Green; Data.res++; }
            else { MessageBox.Show("Ответ не верный попробуйте еще раз"); }//подсчет правильных ответов и переход на следующий уровень
        }

        private void button3_Click(object sender, EventArgs e)
        {
            меню s = new меню();
            s.Show();
            Hide();//переход на другую форму
        }

        private void обучение_Load(object sender, EventArgs e)
        {
            Data.res = 0;//обнуление вкладки рузультат
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1") { axWindowsMediaPlayer1.Ctlcontrols.play(); }
            if (comboBox1.Text == "2") { axWindowsMediaPlayer2.Ctlcontrols.play(); }
            if (comboBox1.Text == "3") { axWindowsMediaPlayer3.Ctlcontrols.play(); }
            if (comboBox1.Text == "4") { axWindowsMediaPlayer4.Ctlcontrols.play(); }
            if (comboBox1.Text == "5") { axWindowsMediaPlayer5.Ctlcontrols.play(); }
            if (comboBox1.Text == "6") { axWindowsMediaPlayer6.Ctlcontrols.play(); }
            if (comboBox1.Text == "7") { axWindowsMediaPlayer7.Ctlcontrols.play(); }
            if (comboBox1.Text == "8") { axWindowsMediaPlayer8.Ctlcontrols.play(); }
        }
    }
}
