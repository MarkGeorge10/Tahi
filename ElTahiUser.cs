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
    
    public partial class ElTahiUser
    {
        public ElTahiUser()
        {
            this.ElTahiPostComponentRelations = new HashSet<ElTahiPostComponentRelation>();
            this.ElTahiPostImages = new HashSet<ElTahiPostImage>();
            this.ElTahiPostImagesRelations = new HashSet<ElTahiPostImagesRelation>();
            this.ElTahiPostVideos = new HashSet<ElTahiPostVideo>();
            this.ELTahiTopUsers = new HashSet<ELTahiTopUser>();
        }
    
        public int ElTahiUserID { get; set; }
        public string ElTahiFirstName { get; set; }
        public string ELTahiSecondName { get; set; }
        public string ElTahiLastName { get; set; }
        public Nullable<System.DateTime> ElTahiUserBirthdate { get; set; }
        public string ElTahiUserEmail { get; set; }
        public string ElTahiUserMobile { get; set; }
        public Nullable<int> ElTahiUserTypeID { get; set; }
        public string ElTahiUserBio { get; set; }
        public Nullable<System.DateTime> ElTahiRegDateTime { get; set; }
        public Nullable<System.DateTime> ElTahiUpdateDT { get; set; }
        public Nullable<System.DateTime> ElTahiLastLoginDT { get; set; }
        public Nullable<int> ELTahiUserStatusID { get; set; }
        public string ELTahiUserName { get; set; }
        public string ElTahiUserPassWord { get; set; }
        public Nullable<int> ELTahiUserCountryID { get; set; }
        public Nullable<int> ELTahiNationalID { get; set; }
        public string ElTahiComAddress { get; set; }
        public string ElTahiComName { get; set; }
        public Nullable<int> ElTahiRestTypeID { get; set; }
    
        public virtual ICollection<ElTahiPostComponentRelation> ElTahiPostComponentRelations { get; set; }
        public virtual ICollection<ElTahiPostImage> ElTahiPostImages { get; set; }
        public virtual ICollection<ElTahiPostImagesRelation> ElTahiPostImagesRelations { get; set; }
        public virtual ICollection<ElTahiPostVideo> ElTahiPostVideos { get; set; }
        public virtual ElTahiStatu ElTahiStatu { get; set; }
        public virtual ICollection<ELTahiTopUser> ELTahiTopUsers { get; set; }
        public virtual ElTahiType ElTahiType { get; set; }
    }
}
