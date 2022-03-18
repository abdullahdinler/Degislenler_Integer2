using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degislenler_Integer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize_notu, vize_ort, final_notu, final_ort, ort, yuzde_vize, yuzde_final, gecme_notu;
            vize_notu = Convert.ToInt16(textBox1.Text);
            final_notu = Convert.ToInt16(textBox2.Text);
            yuzde_vize = Convert.ToInt16(comboBox1.Text);
            yuzde_final = Convert.ToInt16(comboBox2.Text);
            gecme_notu = Convert.ToInt16(comboBox3.Text);
            vize_ort = (vize_notu * yuzde_vize) / 100;
            final_ort = (final_notu * yuzde_final) / 100;
            ort = vize_ort + final_ort;

            if (ort >= gecme_notu)
            {
                string gecme_durumu = "Geçti";
                listBox1.Items.Add("Ortalamanız: " + ort + "   Ders Geçme Durumu: " + gecme_durumu);
                //MessageBox.Show("Ortalamanız: " + ort + "   Ders Geçme Durumu: " + gecme_durumu);
            }
            else
            {
                string gecme_durumu = "Kaldı.";
                listBox1.Items.Add("Ortalamanız: " + ort + "   Ders Geçme Durumu: " + gecme_durumu);
                //MessageBox.Show("Ortalamanız: " + ort + "   Ders Geçme Durumu: " + gecme_durumu);
            }

            textBox1.Text = "";
            textBox2.Text = "";

            

        }
    }
}
