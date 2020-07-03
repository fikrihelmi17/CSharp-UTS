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
    public partial class Daftar_Belanjaan : Form
    {
        int jmlJenis=0;
        string[] nama;
        double[] harga;
        int[] jmlBeli;

        int i = 0;
        double totalSbDiskon=0;
        double diskon=0;
        double total=0;

        public Daftar_Belanjaan()
        {
            InitializeComponent();
        }

        private static double fungsiDiskon(double harga)
        {
            double hargaDiskon = 0;

            if (harga > 150000 && harga <= 350000)
            {
                hargaDiskon = 5;

            }
            else if (harga > 350000 && harga <= 500000)
            {
                hargaDiskon = 10;

            }
            else if (harga > 500000)
            {
                hargaDiskon = 20;
            }
            else
            {
                hargaDiskon = 0;
            }

            return harga*hargaDiskon/100;
        }

        private void proc_total(double totalSbDiskon, double diskon)
        {
            total = totalSbDiskon - diskon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtJmlJenis.Text == "")
            {
                MessageBox.Show("Jumlah Jenis Tidak Boleh Kosong!!!");
                txtJmlJenis.Focus();
            }

            jmlJenis = Convert.ToInt32(txtJmlJenis.Text);

            nama = new string[jmlJenis];
            harga = new double[jmlJenis];
            jmlBeli = new int[jmlJenis];

            MessageBox.Show("Berhasil!");
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
           
            if (i <= jmlJenis - 1)
            {
                nama[i] = txtNama.Text;
                harga[i] = Convert.ToDouble(txtHarga.Text);
                jmlBeli[i] = Convert.ToInt32(txtJmlBeli.Text);

                if (txtJmlJenis.Text == "")
                {
                    MessageBox.Show("Jumlah Jenis Tidak Boleh Kosong!!!");
                    txtJmlJenis.Focus();
                }
                else if (txtNama.Text == "")
                {
                    MessageBox.Show("Nama Belanjaan Tidak Boleh Kosong!!!");
                    txtNama.Focus();
                }
                else if (txtHarga.Text == "")
                {
                    MessageBox.Show("Harga Tidak Boleh Kosong!!!");
                    txtHarga.Focus();
                }
                else if (txtJmlBeli.Text == "")
                {
                    MessageBox.Show("Jumlah Beli Tidak Boleh Kosong!!!");
                    txtJmlBeli.Focus();
                }

                i++;
            }
            else
            {
                MessageBox.Show("Data tidak boleh lebih dari " + jmlJenis);
            }

            txtNama.Clear();
            txtHarga.Clear();
            txtJmlBeli.Clear();
            txtNama.Focus();

        }

        private void txtJmlJenis_TextChanged(object sender, EventArgs e)
        {
            string sjmlJenis = txtJmlJenis.Text;
            if (sjmlJenis.Trim() == "") return;

            for(int i=0; i < sjmlJenis.Length; i++)
            {
                if(!char.IsNumber(sjmlJenis[i]))
                {
                    MessageBox.Show("Hanya Input Angka Saja!!!");
                    txtJmlJenis.Text = "";
                    return;
                }
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            string sharga = txtHarga.Text;
            if (sharga.Trim() == "") return;

            for (int i = 0; i < sharga.Length; i++)
            {
                if (!char.IsNumber(sharga[i]))
                {
                    MessageBox.Show("Hanya Input Angka Saja!!!");
                    txtHarga.Text = "";
                    return;
                }
            }
        }

        private void txtJmlBeli_TextChanged(object sender, EventArgs e)
        {
            string sJmlBeli = txtJmlBeli.Text;
            if (sJmlBeli.Trim() == "") return;

            for (int i = 0; i < sJmlBeli.Length; i++)
            {
                if (!char.IsNumber(sJmlBeli[i]))
                {
                    MessageBox.Show("Hanya Input Angka Saja!!!");
                    txtJmlBeli.Text = "";
                    return;
                }
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {     
                for (int j = 0; j < jmlJenis; j++)
                {
                    listNama.Items.Add(nama[j]);
                    listHarga.Items.Add("Rp" + harga[j]);
                    listJmlBeli.Items.Add(jmlBeli[j]);

                    totalSbDiskon = totalSbDiskon + (harga[j] * jmlBeli[j]);
                }

                  diskon = fungsiDiskon(totalSbDiskon);
                  proc_total(totalSbDiskon, diskon);

                txtHrgSbDiskon.AppendText("Rp" + totalSbDiskon);
                txtDiskon.Text = "Rp" + diskon.ToString();
                txtTotal.Text = "Rp" + total.ToString();
                
            
        }

    }
}
