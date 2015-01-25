﻿using System;
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
                    if (DBIslemleri.MusteriKontrol(mid))
                    {
                        labelMüsteriEkleme.Text = "Bu ID değerinde Müşteri var.";
                        return;
                    }

                    musteri m = new musteri();
                    m.isim = txtİsim.Text;
                    m.mid = mid;
                    DBIslemleri.MusteriEkle(m);

                    if (mid % 2 == 1)
                    {
                        onlineMusteri o = new onlineMusteri();
                        o.email = txtEmail.Text;
                        o.mid = mid;
                        o.szt = DateTime.Now;
                        DBIslemleri.MusteriEkle(o);
                    }
                    else
                    {
                        magazaMusteri ma = new magazaMusteri();
                        ma.telNo = Convert.ToDecimal(txtTelefon);
                        ma.mid = mid;
                        DBIslemleri.MusteriEkle(ma);
                    }

                    labelMüsteriEkleme.Text = "Kayıt işlemi başarıyla gerçekleştirildi.";
                }
                catch (Exception)
                {
                    labelMüsteriEkleme.Text = "Kayıt işlemi gerçekleştirilemedi.";
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme işleminde hata oluştu :" + ex.Message);

            }
        }
    }
}
