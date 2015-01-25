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
                    int sid = Convert.ToInt32(txtSiparisid.Text);
                }
                
 
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !! Alanları Doğru Bir Şekilde Doldurunuz..");
            }
        }
    }
}
