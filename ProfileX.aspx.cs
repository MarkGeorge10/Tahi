using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class ProfileX : System.Web.UI.Page
    {

            db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();

            string personalUserid;
            string comid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["CompID"] != null)
            {
                personalUserid = Session["UserID"].ToString();
                comid = Session["CompID"].ToString();
                int us = int.Parse(personalUserid);
                foreach (var per in DB.TahiSupInformations.Where(u => u.tahiSupUserID == us))
                {
                    persdetail.InnerHtml = "<h6 class='author'><a href='#'>" + per.tahiSupName + "</a></h6><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to Tahi</button></li><li><button>edit post</button></li><li><button>embed Tahi</button></li></ul></div></div></div><p>Phone :       " + per.tahisupPhone +       "</p><p>Tagline :     " + per.tahitagline + "    </p><p>Bio : " + per.tahiwebsiteurl + "</p>";
                    twoOver.InnerHtml    = "<h6 class='author'><a href='#'>      Overview         </a></h6><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to Tahi</button></li><li><button>edit post</button></li><li><button>embed Tahi</button></li></ul></div></div></div><p>Description : " + per.tahisupdescription + "</p><p>company size :" + per.tahisupcompsize + "</p><p>company type : " + per.tahicomptype + "</p><p>since : " + per.tahisupyearfounder + "</p><p>Specialities : " + per.tahisupSpecialities + "</p>";
                    threeloc.InnerHtml   = "<h6 class='author'><a href='#'>Location</a></h6><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to Tahi</button></li><li><button>edit post</button></li><li><button>embed Tahi</button></li></ul></div></div></div><p>Address :" + per.tahisupAddress + "</p>";
                }
                foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == us))
                {

                }
            }

        }

    }
}