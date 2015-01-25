using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class fatura
    {
        public fatura()
        {
            this.odemelers = new List<odemeler>();
        }

        public int fatNo { get; set; }
        public int sipNo { get; set; }
        public System.DateTime tarih { get; set; }
        public Nullable<decimal> indirim { get; set; }
        public virtual siparisler siparisler { get; set; }
        public virtual ICollection<odemeler> odemelers { get; set; }
    }
}
