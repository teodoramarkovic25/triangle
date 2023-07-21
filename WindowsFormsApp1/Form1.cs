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
        public Form1()
        {
            InitializeComponent();
        }

        private void izadjiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void podesavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podesavanje podesavanje = new Podesavanje();
            podesavanje.ShowDialog();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;
            double obim = 0, povrsina = 0;

            if(cmbTrougao.SelectedItem == "Obim")
            {
                a = Properties.Settings.Default.a;
                b = Properties.Settings.Default.b;
                c = Properties.Settings.Default.c;
            }
            else if(cmbTrougao.SelectedItem == "Povrsina")
            {
                a = Properties.Settings.Default.a;
                b = Properties.Settings.Default.b;
                c = Properties.Settings.Default.c;
            }

            obim = a + b + c;
            povrsina = a * b / 2;

            lblObim.Text = obim.ToString("F2");
            lblPovrsina.Text = povrsina.ToString("F2");
        }
    }
}
