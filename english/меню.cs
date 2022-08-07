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
    public partial class меню : Form
    {
        public меню()
        {
            InitializeComponent();
        }

        private void меню_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text +"\n"+ Data.login;
            label2.Text = label2.Text + Data.res.ToString() + "/8";
            for(int i = 0; i < Data.res; i++) { progressBar1.Value += 10; }
            if (progressBar1.Value == 80) { progressBar1.Value = 100; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            отзыв s = new отзыв();
            s.Show();
            Hide();//переход на другую форму
        }

        private void button1_Click(object sender, EventArgs e)
        {
            обучение s = new обучение();
            s.Show();
            Hide();//переход на другую форму
        }
    }
}
