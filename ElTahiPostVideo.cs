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
    
    public partial class ElTahiPostVideo
    {
        public int ElTahiPostVideosID { get; set; }
        public string ElTahiPostVideosURL { get; set; }
        public Nullable<int> ElTahiPostVideosUserID { get; set; }
        public Nullable<int> ElTahiPostVideosStatusID { get; set; }
        public Nullable<System.DateTime> ElTahiPostVideosRegDT { get; set; }
    
        public virtual ElTahiStatu ElTahiStatu { get; set; }
        public virtual ElTahiUser ElTahiUser { get; set; }
    }
}