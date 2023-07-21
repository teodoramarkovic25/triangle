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
    public partial class Podesavanje : Form
    {
        public Podesavanje()
        {
            InitializeComponent();

            txtA.Text = Properties.Settings.Default.a.ToString();
            txtB.Text = Properties.Settings.Default.b.ToString();
            txtC.Text = Properties.Settings.Default.c.ToString();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.a = Double.Parse(txtA.Text);
                Properties.Settings.Default.b = Double.Parse(txtB.Text);
                Properties.Settings.Default.c = Double.Parse(txtC.Text);

                Properties.Settings.Default.Save();
                MessageBox.Show("Podaci su uspješno sačuvani", "Snimanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Neispravan tip podatka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
