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
    
    public partial class ElTahiPostComponent
    {
        public ElTahiPostComponent()
        {
            this.ElTahiPostComponentRelations = new HashSet<ElTahiPostComponentRelation>();
        }
    
        public int ElTahiPostComponentsID { get; set; }
        public string ElTahiPostComponents { get; set; }
        public Nullable<int> ElTahiPostComponentsUserID { get; set; }
        public Nullable<System.DateTime> ElTahiPostComRegDT { get; set; }
    
        public virtual ICollection<ElTahiPostComponentRelation> ElTahiPostComponentRelations { get; set; }
    }
}