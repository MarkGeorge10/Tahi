//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tahi
{
    using System;
    using System.Collections.Generic;
    
    public partial class ELTahiTopSupplier
    {
        public int ElTahiTopSupplierID { get; set; }
        public Nullable<int> ElTahiSupplierID { get; set; }
        public Nullable<int> ElTahiSupplierStatusID { get; set; }
        public Nullable<System.DateTime> ELTahiTopSupplierRegDt { get; set; }
        public Nullable<int> ElTahiTopSupplierCategoryID { get; set; }
    
        public virtual ElTahiStatu ElTahiStatu { get; set; }
        public virtual ElTahiSupplier ElTahiSupplier { get; set; }
    }
}
