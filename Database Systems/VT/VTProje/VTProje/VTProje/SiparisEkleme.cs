using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTProje.UI.Model.Models;
using VTProje.Business;

namespace VTProje.UI
{
    public enum DepoEnum { d1 = 1, d2 = 2, d3 = 3 }
    public partial class SiparisEkleme : Form
    {
        public SiparisEkleme()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(DepoEnum));
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = Convert.ToInt32(txtMüsteriİd.Text);
                int sid = Convert.ToInt32(txtSiparisid.Text);
                short miktar = (short)Convert.ToInt32(txtMiktar.Text);
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
                string ad = Convert.ToString(txtAd.Text);


                siparisler s = new siparisler();
                s.musteriNo = mid;
                s.siparisNo = sid;
                s.tarih = DateTime.Now;

                kitap k = new kitap();
                k.adi = ad;
                k.birimFiyat = fiyat;
                k.miktar = miktar;
                k.parcaNo = 1;
                k.sipNo = sid;
                k.hangiDepo = comboBox1.SelectedIndex;
                lblBilgi.Text = DBIslemleri.SiparisEkle(s, k);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata !! Alanları Doğru Bir Şekilde Doldurunuz..");
            }
        }
    }
}
