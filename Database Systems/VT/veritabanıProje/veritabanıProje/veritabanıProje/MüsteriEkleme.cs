using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanıProje
{
    public partial class MüsteriEkleme : Form
    {
        public MüsteriEkleme()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = Convert.ToInt32(txtMüsteriİd.Text);
                int telefon = Convert.ToInt32(txtTelefon.Text);
                string isim = Convert.ToString(txtİsim.Text);
                string email = Convert.ToString(txtEmail.Text);
                try
                {                 
                    if (MusteriIslemleri.MusteriKontrol(mid))
                    {
                        lblBilgi.Text = "Bu ID değerinde Müşteri var.";
                        return;
                    }

                    musteri m = new musteri();
                    m.isim = txtisim.Text;
                    m.mid = mid;
                    MusteriIslemleri.MusteriEkle(m);

                    if (mid % 2 == 1)
                    {
                        onlineMusteri o = new onlineMusteri();
                        o.email = txtEmail.Text;
                        o.mid = mid;
                        o.szt = DateTime.Now;
                        MusteriIslemleri.MusteriEkle(o);
                    }
                    else
                    {
                        magazaMusteri ma = new magazaMusteri();
                        ma.telNo = Convert.ToDecimal(txtTel);
                        ma.mid = mid;
                        MusteriIslemleri.MusteriEkle(ma);
                    }

                    lblBilgi.Text = "Kayıt işlemi başarıyla gerçekleştirildi.";
                }
                catch (Exception)
                {
                    lblBilgi.Text = "Kayıt işlemi gerçekleştirilemedi.";
                    throw;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !! Alanları Doğru Bir Şekilde Doldurunuz..");
            }
        }
    }
}
