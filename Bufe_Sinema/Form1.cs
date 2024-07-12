using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bufe_Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int bilet = int.Parse(textBox1.Text);
                int su = int.Parse(textBox2.Text);
                int cay = int.Parse(textBox3.Text);
                int misir = int.Parse(textBox4.Text);
                int toplam = bilet * 150 + su * 10 + cay * 25 + misir * 45;
                label11.Text = toplam.ToString();
                kasa = kasa + toplam;
                label14.Text = kasa.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Eksik Veya Hatalı Giriş Yaptınız !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label11.Text = "";
            textBox1.Focus();
        }
    }
}
