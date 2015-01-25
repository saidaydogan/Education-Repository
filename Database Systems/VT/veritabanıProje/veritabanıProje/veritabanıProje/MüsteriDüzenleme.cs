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
    public partial class MüsteriDüzenleme : Form
    {
        public MüsteriDüzenleme()
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
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !! Alanları Doğru Bir Şekilde Doldurunuz..");
            }
        }

        private void txtMüsteriİd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int mid = Convert.ToInt32(txtmid.Text);
                    if (mid % 2 == 1)
                    {
                        onlineMusteri o = (onlineMusteri)MusteriIslemleri.MusteriGetir(mid);
                        lblMid_düzen.Text = o.mid.ToString();
                        txtEmail_düzen.Text = o.email;
                        txtisim_düzen.Text = o.musteri.isim;
                        txtTel_düzen.Text = "Online Müşteri";
                    }
                    else
                    {
                        magazaMusteri o = (magazaMusteri)MusteriIslemleri.MusteriGetir(mid);
                        lblMid_düzen.Text = o.mid.ToString();
                        txtEmail_düzen.Text = "Mağaza Müşterisi";
                        txtisim_düzen.Text = o.musteri.isim;
                        txtTel_düzen.Text = o.telNo.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                
                throw;
            }
           
        }
    }
}
