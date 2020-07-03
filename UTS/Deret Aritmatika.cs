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
    public partial class Deret_Aritmatika : Form
    {
        int[] deretArray;
        int deret = 0;

        int bSuku;
        int sPertama;
        int sTengah;
        int sTerakhir;
       

        public Deret_Aritmatika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSukuPertama_TextChanged(object sender, EventArgs e)
        {
            string sSukuPertama = txtSukuPertama.Text;
            if (sSukuPertama.Trim() == "") return;

            for (int i = 0; i < sSukuPertama.Length; i++)
            {
                if (!char.IsNumber(sSukuPertama[i]))
                {
                    MessageBox.Show("Hanya Input Angka Saja!!!");
                    txtSukuPertama.Text = "";
                    return;
                }
            }
        }

        private void txtBanyakSuku_TextChanged(object sender, EventArgs e)
        {
            string sBanyakSuku = txtBanyakSuku.Text;
            if (sBanyakSuku.Trim() == "") return;

            for (int i = 0; i < sBanyakSuku.Length; i++)
            {
                if (!char.IsNumber(sBanyakSuku[i]))
                {
                    MessageBox.Show("Hanya Input Angka Saja!!!");
                    txtBanyakSuku.Text = "";
                    return;
                }
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            sPertama = Convert.ToInt32(txtSukuPertama.Text);
            bSuku = Convert.ToInt32(txtBanyakSuku.Text);
            deretArray = new int[bSuku];

                if (txtSukuPertama.Text == "")
                {
                    MessageBox.Show("Suku Pertama Tidak Boleh Kosong!!!");
                    txtSukuPertama.Focus();
                }
                if (txtBanyakSuku.Text == "")
                {
                    MessageBox.Show("Banyaknya Suku Tidak Boleh Kosong!!!");
                    txtBanyakSuku.Focus();
                }

            txtSukuTengah.Clear();
            txtSukuTerakhir.Clear();
            listDeret.Items.Clear();
            deret = 0;

            for (int i = 0; i < bSuku; i++)
            {
                deret = deret + sPertama;
                deretArray[i] = deret;

                listDeret.Items.Add(deretArray[i] + "  ");
            }

            if (bSuku % 2 == 1)
            {
                sTengah = deretArray[bSuku / 2];

            } else
            {
                sTengah = deretArray[bSuku / 2 - 1];
            }

            sTerakhir = deretArray[bSuku - 1];

            txtSukuTengah.Text = sTengah.ToString();
            txtSukuTerakhir.Text = sTerakhir.ToString();
        }
    }
}
