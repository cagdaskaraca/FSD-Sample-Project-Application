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
    
    public partial class Urun
    {
        public int UrunAciklama { get; set; }
        public int TextKod { get; set; }
        public string Sira { get; set; }
        public string Ad { get; set; }
        public System.DateTime KisaAd { get; set; }
        public int GrupKod { get; set; }
        public decimal EkGrupKod { get; set; }
        public decimal UreticiKod { get; set; }
        public string Birim { get; set; }
        public string KdvOran { get; set; }
        public string UrunTip { get; set; }
        public string Durum { get; set; }
        public string UretimTarihi { get; set; }
        public string SeriTakip { get; set; }
    }
}