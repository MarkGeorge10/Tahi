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
    
    public partial class CookingMethod
    {
        public CookingMethod()
        {
            this.ElTahiRecipePostMethods = new HashSet<ElTahiRecipePostMethod>();
        }
    
        public int CookmethodID { get; set; }
        public string CookMedthodName { get; set; }
    
        public virtual ICollection<ElTahiRecipePostMethod> ElTahiRecipePostMethods { get; set; }
    }
}
