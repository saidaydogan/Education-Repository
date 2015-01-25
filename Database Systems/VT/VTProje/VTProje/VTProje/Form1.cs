using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTProje.UI
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void btnMüsteriEkleme_Click(object sender, EventArgs e)
        {
            Giriş.ActiveForm.Hide();
            MüsteriEkleme frm = new MüsteriEkleme();
            frm.ShowDialog();
            Giriş frm2 = new Giriş();
            frm2.Visible = true;
        }

        private void btnMüsteriSil_Click(object sender, EventArgs e)
        {
            Giriş.ActiveForm.Hide();
            MüsteriDüzenleme frm = new MüsteriDüzenleme();
            frm.ShowDialog();
            Giriş frm2 = new Giriş();
            frm2.Visible = true;
        }

        private void btnSiparisEkleme_Click(object sender, EventArgs e)
        {
            Giriş.ActiveForm.Hide();
            SiparisEkleme frm = new SiparisEkleme();
            frm.ShowDialog();
            Giriş frm2 = new Giriş();
            frm2.Visible = true;
        }

        private void btnSiparisTakip_Click(object sender, EventArgs e)
        {
            Giriş.ActiveForm.Hide();
            SiparisTakip frm = new SiparisTakip();
            frm.ShowDialog();
            Giriş frm2 = new Giriş();
            frm2.Visible = true;
        }

        private void btnÖdemeTakip_Click(object sender, EventArgs e)
        {
            Giriş.ActiveForm.Hide();
            ÖdemeTakip frm = new ÖdemeTakip();
            frm.ShowDialog();
            Giriş frm2 = new Giriş();
            frm2.Visible = true;
        }
    }
}
