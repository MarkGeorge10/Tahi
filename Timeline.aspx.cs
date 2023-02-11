using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class Timeline : System.Web.UI.Page
    {
         db_a8d12b_amahmyEntities DB = new  db_a8d12b_amahmyEntities();
        string personalUserid;
        string comid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["CompID"] != null)
            {
                personalUserid = Session["UserID"].ToString();
                comid = Session["CompID"].ToString();
                int us = int.Parse(personalUserid);
                foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == us))
                {
                    persodata.InnerHtml += "<h4 class='widget-title'> "+ per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName + " </h4><div class='widget-body'><div class='about-author'><p>"+per.ElTahiUserBio+ "</p> <ul class='author-into-list'><li><a href = '#' ><i class='bi bi-office-bag'></i>" + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enNationality).SingleOrDefault() + "</a></li> <li><a href = '#' >< i class='bi bi-home'></i>" + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enName).SingleOrDefault() + "</a></li> <li><a href = '#' ><i class='bi bi-location-pointer'></i>" + per.ElTahiUserBirthdate + "</a></li><li><a href = '#' >< i class='bi bi-heart-beat'></i>Travel, Swimming</a></li></ul></div></div>";
                    //persdetail.InnerHtml += "<h6 class='author'><a href='profile.html'>" + per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName + "</a></h6><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul> <li><button>copy link to Tahi</button></li><li><button>edit post</button></li><li><button>embed Tahi</button></li></ul> </div> </div> </div> <p>BirthDate : " + per.ElTahiUserBirthdate + "</p><p>Nationalty : " + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enNationality).SingleOrDefault() + "</p><p>Bio : " + per.ElTahiUserBio + "</p>";
                    Tpost.InnerHtml += "<div class='post-title d-flex align-items-center'> <div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'><img src = 'assets/images/profile/profile-small-5.jpg' alt='profile picture'></figure></a> </div><div class='posted-author'><h6 class='author'><a href = 'profile.html' >" + per.ElTahiFirstName + " " + per.ELTahiSecondName + "</a></h6><span class='post-time'>35 min ago</span></div><div class='post-settings-bar'><span></span> <span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li><li><button>edit post</button></li></ul></div></div></div> <div class='post-content'><p class='post-desc'>info</p> <div class='post-thumb-gallery img-gallery'> <div class='row no-gutters'> <div class='col-8'><figure class='post-thumb'>";
                                        //        <a class='gallery-selector' href='assets/images/post/post-large-2.jpg'>
                                        //            <img src = 'assets/images/post/post-2.jpg' alt='post image'>
                                        //        </a>
                                        //    </figure>
                                        //</div>
                                        //<div class='col-4'>
                                        //    <div class='row'>
                                        //        <div class='col-12'>
                                        //            <figure class='post-thumb'>
                                        //                <a class='gallery-selector' href='assets/images/post/post-large-3.jpg'>
                                        //                    <img src = 'assets/images/post/post-3.jpg' alt='post image'>
                                        //                </a>
                                        //            </figure>
                                        //        </div>
                                        //        <div class='col-12'>
                                        //            <figure class='post-thumb'>
                                        //                <a class='gallery-selector' href='assets/images/post/post-large-4.jpg'>
                                        //                    <img src = 'assets/images/post/post-4.jpg' alt='post image'>
                                        //                </a>
                                        //            </figure>
                                        //        </div>
                                        //        <div class='col-12'>
                                        //            <figure class='post-thumb'>
                                        //                <a class='gallery-selector' href='assets/images/post/post-large-5.jpg'> <img src = 'assets/images/post/post-5.jpg' alt='post image'></a></figure></div></div></div></div></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 207 people like this</span> <strong>207</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button></li></ul></div></div>";
                }
                //foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == us))
                //{
                //    if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == us).Count() > 0)
                //    {
                //        proimge.InnerHtml += "<figure class='profile-picture'><a href = 'profile.html'> <img src = 'assets/images/profile/" + persimg.ElTahiProfileImageName + "' alt = 'profile picture'></a></figure>";

                //    }
                //    else
                //    {
                //        proimge.InnerHtml += "<figure class='profile-picture'><a href = 'profile.html'> <img src = 'assets/images/profile/profile-1.jpg' alt = 'profile picture'></a></figure>";
                //    }
                //}
            }

        }
        protected void btnpost_Click(object sender, EventArgs e)
        {
            Fuploadpost.SaveAs(Server.MapPath("~\\assets\\images\\posts\\" + int.Parse(personalUserid) + "-" + Fuploadpost.FileName));

            int sclin = 0;
            int scimag = 0;
            DB.ElTahiPosts.Add( new ElTahiPost {
                ElTahiPostHeader = txtheader.Text,
                ElTahiPostBody = txtarea.Text,
                ELTahiPostRegDT = DateTime.Now,
                ElTahiPostUserID = int.Parse(personalUserid),
                ElTahiPostStatusID = 1,

            });
            DB.SaveChanges();
            sclin = DB.ElTahiPosts.Max(p => p.ElTahiPostID);
            DB.ElTahiPostImages.Add(new ElTahiPostImage {
                ElTahiPostImageUserID = int.Parse(personalUserid),
              ElTahiPostImageStatusID = 1,
                ElTahiPostImageURL = "assets/images/posts/" + int.Parse(personalUserid) + "-" + Fuploadpost.FileName,
                ElTahiPostImageRegDT = DateTime.Now,

            });
            DB.SaveChanges();
            sclin = DB.ElTahiPostImages.Max(p => p.ElTahiPostImageID);
            DB.ElTahiPostImagesRelations.Add(new ElTahiPostImagesRelation {
                ElTahiPostID = sclin,
                ElTahiPostImageID =scimag,
                ElTahiRelationRegUserID = int.Parse(personalUserid),
                ElTahiRelationRegDT = DateTime.Now,

            });
            DB.SaveChanges();

        }
    }
}