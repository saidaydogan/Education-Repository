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

namespace VTProje.UI
{
    public partial class ÖdemeTakip : Form
    {
        public ÖdemeTakip()
        {
            InitializeComponent();
        }

        private void panelMüsteriFaturlari_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panelMüsteriFaturalari.Visible = true;
                panelSiparisFaturalari.Visible = false;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panelSiparisFaturalari.Visible = true;
                panelMüsteriFaturalari.Visible = false;
            }
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            try
            {
                int miktar = Convert.ToInt32(txtMiktar.Text);
                if (radioButton1.Checked == true)
                {
                    int mid = Convert.ToInt32(txtMüsteriİd.Text);
                }
                else
                {
                    int sid = Convert.ToInt32(txtID.Text);
                }
                
 
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !! Alanları Doğru Bir Şekilde Doldurunuz..");
            }
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int sid = Convert.ToInt32(txtID.Text);

                    dgViewFatura.DataSource = DBIslemleri.FaturaGetir(sid);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sipariş bilgileri getirilirken hata oluştu.");
            }
        }

        private void txtMüsteriİd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int mid = Convert.ToInt32(txtMüsteriİd.Text);

                    dgViewFatura.DataSource = DBIslemleri.FaturaGetirByMusteri(mid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri bilgileri getirilirken hata oluştu.");
            }
        }
    }
}
