//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServisTakipWeb.Areas.FirmaYonetici.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class TamamlananCagrilar
    {
        public int TamamlananID { get; set; }
        public Nullable<int> TamamlayanYoneticiID { get; set; }
        public Nullable<int> TamamlayanCalisanID { get; set; }
        public string FormNo { get; set; }
        public int MID { get; set; }
        public string YetkiliKisi { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public string BildirilenAriza { get; set; }
        public string HizmetTipi { get; set; }
        public string CihazinHizmetDurumu { get; set; }
        public System.DateTime CagrininBildirigiTarih { get; set; }
        public System.DateTime HizmetBaslangicTarihi { get; set; }
        public System.DateTime HizmetBitisTarihi { get; set; }
        public int CagriKayitNo { get; set; }
        public bool MesaiSaatiIcindeMi { get; set; }
        public string YapılanIsinAciklamasi { get; set; }
        public string Sonuc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool AnketYapildiMi { get; set; }
        public Nullable<int> Cihaz1 { get; set; }
        public Nullable<int> Cihaz2 { get; set; }
        public Nullable<int> Cihaz3 { get; set; }
        public Nullable<int> Cihaz4 { get; set; }
        public Nullable<int> UcretliParca1 { get; set; }
        public Nullable<int> UcretliParca2 { get; set; }
        public Nullable<int> UcretliParca3 { get; set; }
        public Nullable<int> UcretliIscilik1 { get; set; }
        public Nullable<int> UcretliIscilik2 { get; set; }
        public Nullable<int> UcretliIscilik3 { get; set; }
    
        public virtual CihazBilgileri CihazBilgileri { get; set; }
        public virtual CihazBilgileri CihazBilgileri1 { get; set; }
        public virtual CihazBilgileri CihazBilgileri2 { get; set; }
        public virtual CihazBilgileri CihazBilgileri3 { get; set; }
        public virtual UcretliParca UcretliParca { get; set; }
        public virtual UcretliParca UcretliParca4 { get; set; }
        public virtual UcretliParca UcretliParca5 { get; set; }
        public virtual UcretliIscilik UcretliIscilik { get; set; }
        public virtual UcretliIscilik UcretliIscilik4 { get; set; }
        public virtual UcretliIscilik UcretliIscilik5 { get; set; }
    }
}