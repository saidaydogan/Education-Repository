using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class kitap
    {
        public int sipNo { get; set; }
        public int parcaNo { get; set; }
        public short miktar { get; set; }
        public decimal birimFiyat { get; set; }
        public string adi { get; set; }
        public int hangiDepo { get; set; }
        public virtual depo depo { get; set; }
        public virtual siparisler siparisler { get; set; }
    }
}
