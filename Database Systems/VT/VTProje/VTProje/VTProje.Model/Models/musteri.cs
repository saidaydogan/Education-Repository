using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class musteri
    {
        public musteri()
        {
            this.siparislers = new List<siparisler>();
        }

        public int mid { get; set; }
        public string isim { get; set; }
        public virtual magazaMusteri magazaMusteri { get; set; }
        public virtual onlineMusteri onlineMusteri { get; set; }
        public virtual ICollection<siparisler> siparislers { get; set; }
    }
}
