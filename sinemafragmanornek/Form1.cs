using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemafragmanornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu sayfa Efecan Tekin'e aittir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void johnWickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pcteternalsunshine.Visible = false;
            PctMatrix.Visible = false;
            PctJumpStreet.Visible = false;
            PctJohnWick.Visible = true;
            label1.Visible = true;
            label1.Text = "John Wick";
        }

        private void eternalSunshineOfTheSpotlessMindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PctJumpStreet.Visible = false;
            PctJohnWick.Visible = false;
            PctMatrix.Visible = false;
            Pcteternalsunshine.Visible = true;
            label1.Visible = true;
            label1.Text = "Eternal Sunshine of the Spotless Mind";
        }

        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PctJumpStreet.Visible = false;
            PctJohnWick.Visible = false;
            Pcteternalsunshine.Visible = false;
            PctMatrix.Visible= true;
            label1.Visible = true;
            label1.Text = "Matrix";
        }

        private void jumpStreetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PctMatrix.Visible = false;
            PctJohnWick.Visible = false;
            Pcteternalsunshine.Visible = false;
            PctJumpStreet.Visible = true;
            label1.Visible = true;
            label1.Text = "Jump Street";
        }
    }
}
