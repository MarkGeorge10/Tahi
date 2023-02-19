using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();

        string personalUserid;
        string comid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["CompID"] != null)
            {
                if (!IsPostBack)
                {
                    personalUserid = Session["UserID"].ToString();
                    comid = Session["CompID"].ToString();
                    int us = int.Parse(personalUserid);
                    // string pr = DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == us).Select(l => l.ElTahiProfileImageName).LastOrDefault().ToString();

                    //foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == us))
                    //{
                    //    persdetail.InnerHtml += "<h6 class='author'><a href='profile.html'>" + per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName + "</a></h6><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul> <li><button>copy link to Tahi</button></li><li><button>edit post</button></li><li><button>embed Tahi</button></li></ul> </div> </div> </div> <p>BirthDate : " + per.ElTahiUserBirthdate + "</p><p>Nationalty : " + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enNationality).SingleOrDefault() + "</p><p>Bio : " + per.ElTahiUserBio + "</p>";
                    //}
                    if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == us).Count() > 0)
                    {
                        foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == us))
                    {



                            proimge.InnerHtml = "<figure class='profile-picture'><a href = 'profile.aspx'> <img src = 'assets/images/profile/" + persimg.ElTahiProfileImageName + "' alt = 'profile picture' style='width: 170px; height: auto;'></a></figure>";

                      
                    }
                    }
                    else
                    {
                        proimge.InnerHtml += "<figure class='profile-picture'><a href = 'profile.html'> <img src = 'assets/images/profile/profile-1.jpg' alt = 'profile picture'></a></figure>";
                    }
                }
            }

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (fproPhoto.HasFile)
            {
                // PostID = int.Parse(QS);
                fproPhoto.SaveAs(Server.MapPath("~\\assets\\images\\profile\\" + int.Parse(Session["UserID"].ToString()) + "-" + fproPhoto.FileName));

                DB.ElTahiProfileImages.Add(new ElTahiProfileImage
                {
                    ElTahiProfileImageUserID = int.Parse(Session["UserID"].ToString()),
                    ElTahiProfileImageName = int.Parse(Session["UserID"].ToString()) + "-" + fproPhoto.FileName,
                    ElTahiProfileImageURL = "assets/images/profile/" + int.Parse(Session["UserID"].ToString()) + "-" + fproPhoto.FileName,
                    UploadDateTime = DateTime.Now

                });
                DB.SaveChanges();
            }
        }
    }
}