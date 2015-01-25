using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class odemeler
    {
        public int fatNo { get; set; }
        public int takNo { get; set; }
        public decimal odemeMiktari { get; set; }
        public string odemeTipi { get; set; }
        public string kartTipi { get; set; }
        public Nullable<System.DateTime> son_kul_tar { get; set; }
        public Nullable<int> kartNo { get; set; }
        public string bankaKodu { get; set; }
        public Nullable<int> cekNo { get; set; }
        public virtual fatura fatura { get; set; }
    }
}
