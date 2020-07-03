using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void perhitunganBelanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daftar_Belanjaan belanja = new Daftar_Belanjaan();
            belanja.Show();
            this.Hide();
        }

        private void deretAritmatikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deret_Aritmatika deret = new Deret_Aritmatika();
            deret.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
