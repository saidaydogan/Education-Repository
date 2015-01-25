using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class magazaMusteri
    {
        public int mid { get; set; }
        public Nullable<decimal> telNo { get; set; }
        public virtual musteri musteri { get; set; }
    }
}
