using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWinForm
{
    public partial class Form1 : Form
    {
        DataIslemleri dataIslemleri;
        List<Personel> personelListe;

        public Form1()
        {
            InitializeComponent();
            dataIslemleri = new DataIslemleri();

            
        }

        private void btn_personelGetir_Click(object sender, EventArgs e)
        {
            personelListe = dataIslemleri.PersonelGetir(20);
            lst_Personel.DataSource = personelListe;
        }

        private void lst_Personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel temp = personelListe[lst_Personel.SelectedIndex];
            txt_isim.Text = temp.isim;
            txt_soyisim.Text = temp.soyisim;
            txt_emailAdres.Text = temp.emailadres;
            txt_firmaAdi.Text = temp.firmaAdi;
            txt_ulke.Text = temp.ulke;
        }

        private void btn_personelKaydet_Click(object sender, EventArgs e)
        {
            dataIslemleri.PersonelKaydet("C:\\Odev\\",personelListe);
            
        }
    }
}
