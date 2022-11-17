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
    public partial class Form1 : Form
    {
        private Form active;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelForm(new onas());
        }
        
        private void PanelForm(Form fm)
        {
            if (active != null) 
                active.Close();

            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.BringToFront();
            fm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelForm(new Бронирование());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelForm(new МОИ_НОМЕРА());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelForm(new onas());
        }
    }
}
