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
    
    public partial class ElTahiPost
    {
        public ElTahiPost()
        {
            this.ElTahiPostComponentRelations = new HashSet<ElTahiPostComponentRelation>();
            this.ElTahiPostImagesRelations = new HashSet<ElTahiPostImagesRelation>();
            this.ElTahiPostVideosRelations = new HashSet<ElTahiPostVideosRelation>();
        }
    
        public int ElTahiPostID { get; set; }
        public string ElTahiPostHeader { get; set; }
        public string ElTahiPostBody { get; set; }
        public Nullable<int> ElTahiPostUserID { get; set; }
        public Nullable<int> ElTahiPostStatusID { get; set; }
        public Nullable<System.DateTime> ELTahiPostRegDT { get; set; }
        public Nullable<System.DateTime> ElTahiPostUpdateDT { get; set; }
    
        public virtual ICollection<ElTahiPostComponentRelation> ElTahiPostComponentRelations { get; set; }
        public virtual ICollection<ElTahiPostImagesRelation> ElTahiPostImagesRelations { get; set; }
        public virtual ICollection<ElTahiPostVideosRelation> ElTahiPostVideosRelations { get; set; }
    }
}
