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
    public partial class авторизация : Form
    {
        public авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();//выход
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")//проверка на правильность пароля и логина
            {
                Data.res = 0;
                MessageBox.Show("Добро пожаловать!");
                Data.login = textBox1.Text;
                меню s = new меню();
                s.Show();
                Hide();//переход на другую форму
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";//объявление об ошибке ввода
            }
        }
    }
    static class Data
    {
        public static string login { get; set; }// объявление глобальной переменной
        public static int res { get; set; }
    }
}
