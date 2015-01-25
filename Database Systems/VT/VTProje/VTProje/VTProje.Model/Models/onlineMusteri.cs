using System;
using System.Collections.Generic;

namespace VTProje.UI.Model.Models
{
    public partial class onlineMusteri
    {
        public int mid { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> szt { get; set; }
        public virtual musteri musteri { get; set; }
    }
}
