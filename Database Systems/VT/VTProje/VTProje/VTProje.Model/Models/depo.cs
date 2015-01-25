using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class depo
    {
        public depo()
        {
            this.kitaps = new List<kitap>();
        }

        public int did { get; set; }
        public string konum { get; set; }
        public virtual ICollection<kitap> kitaps { get; set; }
    }
}
