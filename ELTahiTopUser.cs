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
    
    public partial class ELTahiTopUser
    {
        public int ElTahiTopUserID { get; set; }
        public Nullable<int> ElTahiUserID { get; set; }
        public Nullable<int> ElTahiUserStatusID { get; set; }
        public Nullable<System.DateTime> ELTahiTopUserRegDt { get; set; }
        public Nullable<int> ElTahiTopUserCategoryID { get; set; }
    
        public virtual ElTahiCategory ElTahiCategory { get; set; }
        public virtual ElTahiStatu ElTahiStatu { get; set; }
        public virtual ElTahiUser ElTahiUser { get; set; }
    }
}
