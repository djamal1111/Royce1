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
    public partial class onas : Form
    {
        private Form active;

        public onas()
        {
            InitializeComponent();
        }

        private void onas_Load(object sender, EventArgs e)
        {
            PanelForm(new описание());
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

        private void label1_Click(object sender, EventArgs e)
        {
            PanelForm(new описание());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PanelForm(new ГАЛЕРЕЯ());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PanelForm(new ИЗВЕСТНЫЕ_ГОСТИ());
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gold;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkGoldenrod;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gold;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkGoldenrod;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gold;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkGoldenrod;
        }
    }
}
