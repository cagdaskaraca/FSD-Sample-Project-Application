//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FSD_Sample_Project_App.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class FSDSampleProjectdb
    {
        public int Id { get; set; }
        public string UrunAciklama { get; set; }
        public string TextKod { get; set; }
        public Nullable<int> Sira { get; set; }
        public Nullable<int> Agirlik { get; set; }
        public string Ad { get; set; }
        public string KisaAd { get; set; }
        public Nullable<int> GrupKod { get; set; }
        public Nullable<int> EkGrupKod { get; set; }
        public string UreticiKod { get; set; }
        public string Birim { get; set; }
        public Nullable<int> KdvOran { get; set; }
        public Nullable<int> UrunTip { get; set; }
        public Nullable<int> Durum { get; set; }
        public Nullable<System.DateTime> UretimTarihi { get; set; }
        public Nullable<int> SeriTakip { get; set; }
    }
}
