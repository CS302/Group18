using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            int a = Sum(10, 15);
        }

        [Obsolete("Новый метод Sum(double, double)", false)]
        private int Sum(int x, int y)
        {
            return x + y;
        }

        private double Sum(double x, double y)
        {
            return x + y;
        }

        #region Обработчик нажатия на кнопку

        /// <summary>
        /// Обработчик нажатия на кнопку
        /// </summary>
        /// <param name="sender">Объект инициатор события</param>
        /// <param name="e">Параметры события</param>
        private void button1_Click(object sender, EventArgs e)
        {
//#error Дописать проверку!!!!
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int sum = x + y;
            textBox3.Text = sum.ToString();
        }
        #endregion
    }
}
