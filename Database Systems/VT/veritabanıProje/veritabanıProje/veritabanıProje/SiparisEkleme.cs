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
    public partial class SiparisEkleme : Form
    {
        public SiparisEkleme()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = Convert.ToInt32(txtMüsteriİd.Text);
                int miktar = Convert.ToInt32(txtMiktar.Text);
                string ad = Convert.ToString(txtAd.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !! Alanları Doğru Bir Şekilde Doldurunuz.."); 
            }
        }
    }
}
