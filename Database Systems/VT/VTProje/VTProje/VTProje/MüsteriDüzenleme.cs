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
    public partial class MüsteriDüzenleme : Form
    {
        public MüsteriDüzenleme()
        {
            InitializeComponent();
        }
        private bool Kontrol()
        {
            if (txtMüsteriİd.Text != "")
            {
                try
                {
                    int mid = Convert.ToInt32(txtMüsteriİd.Text);
                    if (mid % 2 == 1)
                    {
                        if (txtEmail.Text == "" && txtİsim.Text == "")
                        {
                            MessageBox.Show("Email ve İsim alanları online müşteri için boş bırakılamaz.");
                            return false;
                        }
                    }
                    else
                    {
                        if (txtTelefon.Text == "")
                        {
                            MessageBox.Show("Telefon alanı mağaza müşterisi için boş bırakılamaz.");
                            return false;
                        }

                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("Müşteri ID değeri geçerli değil.");
                    return false;

                }
            }
            else
            { MessageBox.Show("Müşteri ID değeri boş bırakılamaz."); return false; }

        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kontrol())
                {
                    int mid = Convert.ToInt32(txtMüsteriİd.Text);
                    int telefon = Convert.ToInt32(txtTelefon.Text);
                    string isim = Convert.ToString(txtİsim.Text);
                    string email = Convert.ToString(txtEmail.Text);
                    if (mid % 2 == 1)
                    {
                        labelMüsteriDüzenleme.Text = DBIslemleri.MusteriDuzenle(mid, new onlineMusteri() { email = email, szt = DateTime.Now });
                    }
                    else
                        labelMüsteriDüzenleme.Text = DBIslemleri.MusteriDuzenle(mid, new magazaMusteri() { telNo = telefon });
                }
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
                    int mid = Convert.ToInt32(txtMüsteriİd.Text);
                    if (mid % 2 == 1)
                    {
                        onlineMusteri o = (onlineMusteri)DBIslemleri.MusteriGetir(mid);
                        if (o == null)
                        {
                            labelMüsteriDüzenleme.Text = "ID= " + mid + " olan müşteri bulunamadı.";
                            return;
                        }
                        txtEmail.Text = o.email;
                        txtİsim.Text = o.musteri.isim;
                        txtTelefon.Text = "Online Müşteri";
                    }
                    else
                    {
                        magazaMusteri o = (magazaMusteri)DBIslemleri.MusteriGetir(mid);
                        if (o == null)
                        {
                            labelMüsteriDüzenleme.Text = "ID= " + mid + " olan müşteri bulunamadı.";
                            return;
                        }
                        txtEmail.Text = "Mağaza Müşterisi";
                        txtİsim.Text = o.musteri.isim;
                        txtTelefon.Text = o.telNo.ToString();
                    }
                    txtMüsteriİd.Enabled = false;
                    labelMüsteriDüzenleme.Text = "Müşteri bilgileri getirildi.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri bilgileri getirilirken hata oluştu Hata: " + ex.Message);

            }
        }

        private void btnMüsteriSil_Click(object sender, EventArgs e)
        {
            if (Kontrol())
            {
                int mid = Convert.ToInt32(txtMüsteriİd.Text);
                labelMüsteriDüzenleme.Text = DBIslemleri.MusteriSil(mid);
            }
        }
    }
}
