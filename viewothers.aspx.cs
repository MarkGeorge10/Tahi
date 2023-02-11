using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class viewothers : System.Web.UI.Page
    {
        db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
        string personalUserid;
        string comid;
        string postimagurl;
        string Name;
        string Url;
        string method;
        protected void Page_Load(object sender, EventArgs e)
        {
            string QS = Request.QueryString["RecID"];
            int recid = int.Parse(QS);
            if (Session["UserID"] != null && Session["CompID"] != null && QS != null)
            {
                personalUserid = Session["UserID"].ToString();
                comid = Session["CompID"].ToString();
                int us = int.Parse(personalUserid);
                foreach (var pos in DB.ElTahiOtherPosts.Where(k => k.ElTahiOtherPostsID == recid).ToList())
                {
                    foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == pos.ElTahiPostUser))
                    {
                        Name = per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName;
                    }
                    foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == pos.ElTahiPostUser))
                    {
                        if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == pos.ElTahiPostUser).Count() > 0)
                        {
                            Url = persimg.ElTahiProfileImageName;

                        }
                        else
                        {
                            Url = "profile-1.jpg' ";
                        }
                 
                        foreach (var pjob in DB.ElTahiOtherPosts.Where(h => h.ElTahiOtherPostsID == recid))
                        {
                            int h =int.Parse(DB.ELTahiPerantPosts.Where(o => o.ELTahiPostPerantID == pjob.ElTahiPerantPostID).Select(l => l.ELTahiPostType).SingleOrDefault().ToString());
                            //method = "Job Title :" + pjob.TahiJobTitle + "</br>" + "Company :" + pjob.TahiJobComp + "</br>" + "Workplace :" + pjob.TahiJobWorkplace + "</br>" + "Job Location :" + pjob.TahiJobLocation + "</br>" + "Job Type :" + pjob.TahiJobType + "</br>" + "Description :";
                            if (h == 5)
                            {
                                prof.InnerHtml += " <div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div>                                <div class='posted-author'> <h6 class='author'><a href = '' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div>";
                                detail.InnerHtml += "<div class='post -content'><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pjob.ElTahiOtherPostImageURL + "'><img src ='Files/" + pjob.ElTahiOtherPostImageURL + "' alt ='post image'></a> </figure></div><h5 style='font-weight: bold;'>" + pjob.ElTahiOtherPostTitle + "</h5><br><h7 style='font-weight: bold;'>" + pjob.ElTahiProvideAdvice + "</h7><p class='post-desc'>" + pjob.ElTahiotherPostDetail + "</p></div></div>";

                                //detail.InnerHtml += "<div class='post -content'><br><h7 style='font-weight: bold;'>" + pjob.ElTahiOtherPostTitle + "</h7><br><h7 style='font-weight: bold;'>" + pjob.ElTahiProvideAdvice + "</h7><p class='post-desc'>" + pjob.ElTahiotherPostDetail + "</p></div></div>";
                            }
                            else {
                                prof.InnerHtml += " <div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div>                                <div class='posted-author'> <h6 class='author'><a href = '' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div>";
                                detail.InnerHtml += "<div class='post -content'><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pjob.ElTahiOtherPostImageURL + "'><img src ='Files/" + pjob.ElTahiOtherPostImageURL + "' alt ='post image'></a> </figure></div><h5 style='font-weight: bold;'>" + pjob.ElTahiOtherPostTitle + "</h5><br><p class='post-desc'>" + pjob.ElTahiotherPostDetail + "</p></div></div>";

                            }

                        }
                    }



                }
            }
        }
    }
}