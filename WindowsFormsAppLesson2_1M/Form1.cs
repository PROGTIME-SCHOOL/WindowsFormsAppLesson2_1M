using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson2_1M
{
    public partial class Form1 : Form
    {
        // метод инициализации
        public Form1()
        {
            InitializeComponent();
        }

        // метод загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "НЕ НАЖИМАЙ";
            label1.Text = "Made by Viosagmir";
            textBox1.Text = "Сотри тут";
        }

        // метод нажатия на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "=^_^=";
            button1.BackColor = Color.Blue;
            button1.Enabled = false;
            label1.Text = textBox1.Text;
        }

        // метод нажатия на кнопку 2
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Orange;
            button1.Text = "НЕ НАЖИМАЙ";
        }
    }
}
