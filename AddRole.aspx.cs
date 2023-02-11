using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class AddRole : System.Web.UI.Page
    {
         db_a8d12b_amahmyEntities DB = new  db_a8d12b_amahmyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            DB.ElTahiRoles.Add(new ElTahiRole {
                ElTahiRole1 = txtRole.Text,
                ElTahiRoleDesc =txtRoleDes.Text,
                ElTahiRegDT=DateTime.Now,
                ElTahiRoleUserID=1,
                RoleActivavtionFlag=chkflag.Checked
            });
            DB.SaveChanges();
        }
    }
}