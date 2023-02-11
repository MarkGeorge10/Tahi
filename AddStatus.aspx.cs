using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class AddStatus : System.Web.UI.Page
    {
         db_a8d12b_amahmyEntities DB = new  db_a8d12b_amahmyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            DB.ElTahiStatus.Add(new ElTahiStatu {
                ElTahiStatus = txtstatus.Text,
                ActivationFlag = chkflag.Checked,
                ElTahiStatusUpdateDT = DateTime.Now,
                ElTahiStatusRegDT=DateTime.Now,
                ElTahiStatusRegAdminID = 1,
                ElTahiStatusUpdateAdminID = 1,
            });
      
            DB.SaveChanges();

        }
    }
}