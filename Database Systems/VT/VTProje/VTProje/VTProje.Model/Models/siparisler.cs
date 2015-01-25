using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class siparisler
    {
        public siparisler()
        {
            this.faturas = new List<fatura>();
            this.kitaps = new List<kitap>();
        }

        public int siparisNo { get; set; }
        public System.DateTime tarih { get; set; }
        public int musteriNo { get; set; }
        public virtual ICollection<fatura> faturas { get; set; }
        public virtual ICollection<kitap> kitaps { get; set; }
        public virtual musteri musteri { get; set; }
    }
}
