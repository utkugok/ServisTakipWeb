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
    
    public partial class MusteriCalisani
    {
        public int McID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int MusteriID { get; set; }
    
        public virtual Musteri Musteri { get; set; }
    }
}
