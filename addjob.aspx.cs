using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class addjob : System.Web.UI.Page
    {
        db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
        string personalUserid;
        string comid;
        int maxpost;
        int recipepostm;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["CompID"] != null)
            {
              
                    personalUserid = Session["UserID"].ToString();
                    comid = Session["CompID"].ToString();
               
            }
                }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            DB.ELTahiPerantPosts.Add(new ELTahiPerantPost{
                ElTahiPostRegDT=DateTime.Now,
                ElTahiPostUserID = int.Parse(personalUserid),
                ELTahiPostType = 2,

            });
            DB.SaveChanges();
           id = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);

            DB.ELTahiJobPosts.Add(new ELTahiJobPost {
                TahiJobComp = txtcomp.Text,
                TahiJobTitle = Txtjobtitle.Text,
                TahiJobDescraption = txtarea.Text,
                TahiJobLocation =txtjobloc.Text,
                TahiJobWorkplace = txtWP.Text,
                TahiJobType = txtjobtype.Text,
                TahiJobRegesterDateT = DateTime.Now,
                TahiJobUserID = int.Parse(personalUserid),
                TahiJobFlag = true,
                ElTahiPerantPostID = id,
            });
            DB.SaveChanges();
        }
    }
}