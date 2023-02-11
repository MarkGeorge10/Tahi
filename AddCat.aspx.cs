using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    
    public partial class AddCat : System.Web.UI.Page
    {
       db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            int elstatus = int.Parse(DropDownList1.SelectedValue);
            DB.ElTahiCategories.Add(new ElTahiCategory
            {
                ElTahiCategory1 = txtCategory.Text,
                ElTahiCategoryStatusID = elstatus,
                ElTahiCategoryRegUserID = 1,
                ElTahiCategoryRegDT = DateTime.Now,
                ElTahiCategoryActivationFlag = chkflag.Checked,


            });
            DB.SaveChanges();
            


        }
    }
}