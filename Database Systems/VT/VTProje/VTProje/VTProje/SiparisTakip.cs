using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTProje.Business;
using VTProje.UI.Model.Models;

namespace VTProje.UI
{
    public partial class SiparisTakip : Form
    {
        public SiparisTakip()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kontrol())
                {
                    int sid = Convert.ToInt32(txtSiparisid.Text);
                    int mid = Convert.ToInt32(txtMüsteriİd.Text);
                    int miktar = Convert.ToInt32(txtMiktar.Text);
                    string ad = Convert.ToString(txtAd.Text);

                    fatura f = new fatura();
                    f.sipNo = sid;
                    f.tarih = DateTime.Now;
                    f.indirim = Convert.ToDecimal(txtIndirim.Text);
                    f.fatNo = sid;
                    lblBilgi.Text = DBIslemleri.FaturaEkle(f);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !! Alanları Doğru Bir Şekilde Doldurunuz..");
            }
        }
        private bool Kontrol()
        {
            return true;
        }
        private void txtSiparisid_KeyUp(object sender, KeyEventArgs e)
        {
            if (Kontrol())
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int sid = Convert.ToInt32(txtSiparisid.Text);
                    siparisler s = DBIslemleri.SiparisGetir(sid);
                    txtMüsteriİd.Text = s.musteriNo.ToString();
                    txtSiparisid.Text = s.siparisNo.ToString();
                    dateTimePickerSiparisTakip.Value = s.tarih;

                    kitap k = DBIslemleri.KitapGetir(sid);
                    txtAd.Text = k.adi;
                    txtBFiyat.Text = k.birimFiyat.ToString();
                    txtMiktar.Text = k.miktar.ToString();
                    comboBox1.SelectedIndex = k.hangiDepo;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Kontrol())
            {
                int sid = Convert.ToInt32(txtSiparisid.Text);
                int mid = Convert.ToInt32(txtMüsteriİd.Text);
                string ad = Convert.ToString(txtAd.Text);
                short miktar = (short)Convert.ToInt32(txtMiktar.Text);
                decimal fiyat = Convert.ToDecimal(txtBFiyat.Text);

                siparisler s = new siparisler();
                s.musteriNo = mid;
                s.siparisNo = sid;
                s.tarih = DateTime.Now;

                kitap k = new kitap();
                k.adi = ad;
                k.birimFiyat = fiyat;
                k.miktar = miktar;
                k.parcaNo = 1;
                k.hangiDepo = comboBox1.SelectedIndex;
                lblBilgi.Text = DBIslemleri.SiparisDuzenle(s, k);
            }
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            if (Kontrol())
            {
                int sid = Convert.ToInt32(txtSiparisid.Text);
                lblBilgi.Text = DBIslemleri.SiparisSil(sid);
            }
        }
    }
}
