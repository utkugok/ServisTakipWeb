//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServisTakipWeb.Areas.Firma.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firma()
        {
            this.FirmaCalisani = new HashSet<FirmaCalisani>();
            this.FirmaYonetici = new HashSet<FirmaYonetici>();
        }
    
        public int ID { get; set; }
        public string FirmaKodu { get; set; }
        public string FirmaAdi { get; set; }
        public string YetkiliKisi { get; set; }
        public string Gsm { get; set; }
        public string FirmaTel { get; set; }
        public string webSitesi { get; set; }
        public string YoneticiUserName { get; set; }
        public string YoneticiPassword { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public int AdminID { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FirmaCalisani> FirmaCalisani { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FirmaYonetici> FirmaYonetici { get; set; }
    }
}