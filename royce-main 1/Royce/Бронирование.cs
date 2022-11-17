using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royce
{
    public partial class Бронирование : Form
    {
        int a;//общая сумма
        int n;
        

        public Бронирование()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (comboBox1.SelectedIndex == 1)
            {
                a = 5000;
            }
            else
            {
                a = 2500;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            n = (Convert.ToInt32(numericUpDown1.Value));
            
                a = a * n;
            
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                a = a + 2000;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                a = a + 4000;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = Today;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = a.ToString();
        }
    }
}
