using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class wall : System.Web.UI.Page
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
            if (Session["UserID"] != null && Session["CompID"] != null)
            {
                personalUserid = Session["UserID"].ToString();
                comid = Session["CompID"].ToString();
                int us = int.Parse(personalUserid);
                foreach (var ppp in DB.ELTahiPerantPosts.OrderByDescending(l => l.ElTahiPostRegDT).ToList())
                {

                    if (ppp.ELTahiPostType == 1)
                    {
                        foreach (var pos in DB.ElTahiRescipePosts.Where(j=>j.ElTahiPerentPostID == ppp.ELTahiPostPerantID))
                        {
                            foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == pos.ElTahiRecipePostUserID))
                            {
                                Name = per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName;
                            }
                            foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == pos.ElTahiRecipePostUserID))
                            {
                                if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == pos.ElTahiRecipePostUserID).Count() > 0)
                                {
                                    Url = persimg.ElTahiProfileImageName;

                                }
                                else
                                {
                                    Url = "profile-1.jpg' ";
                                }
                            }



                            foreach (var posmethed in DB.ElTahiRecipePostMethods.Where(k => k.ElTahiRecipePostID == pos.ElTahiRecipePostID))
                            {
                                method = "Cuisine :" + posmethed.TahiCuisine.ElTahiCuisineName + "</br>" + "Recipe Type :" + posmethed.EltahiRecipeType.RecipeTypeName + "</br>" + "Cooking Method :" + posmethed.CookingMethod.CookMedthodName;
                            }
                            foreach (var posimg in DB.ElTahiRecipePostImagesRelations.Where(l => l.ElTahiRecipePostID == pos.ElTahiRecipePostID))
                            {
                                foreach (var pimg in DB.ElTahiPostImages.Where(p => p.ElTahiPostImageID == posimg.ElTahiPostImageID))
                                {
                                    // postimagurl = pimg.ElTahiPostImageURL;
                                    postview.InnerHtml += "<div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = 'profile.html' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'RecipDetailView.aspx?RecID=" + pos.ElTahiRecipePostID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiRecipePostHeader + "</h7><br><h7 style='font-weight: bold;color: black;'>" + method + "</h7><p class='post-desc'>" + pos.ElTahiRecipePostBody + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pimg.ElTahiPostImageURL + "'><img src ='Files/" + pimg.ElTahiPostImageURL + "' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";

                                }
                            }
                        }
                    }
                    else if (ppp.ELTahiPostType == 2)
                    {
                        foreach (var pos in DB.ELTahiJobPosts.Where(l=>l.ElTahiPerantPostID == ppp.ELTahiPostPerantID))
                        {
                            foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == pos.TahiJobUserID))
                            {
                                Name = per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName;
                            }
                            foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == pos.TahiJobUserID))
                            {
                                if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == pos.TahiJobUserID).Count() > 0)
                                {
                                    Url = persimg.ElTahiProfileImageName;

                                }
                                else
                                {
                                    Url = "profile-1.jpg' ";
                                }
                            }



                         
                                method =  "Company :" + pos.TahiJobComp + "</br>" + "Workplace :" + pos.TahiJobWorkplace + "</br>" + "Job Location :" + pos.TahiJobLocation + "</br>" + "Job Type :" + pos.TahiJobType + "</br>" + "Description :";

                                postview.InnerHtml += "<div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '#' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'jobdetail.aspx?RecID=" + pos.TahiJobPostID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.TahiJobTitle + "</h7><br><h7 style='font-weight: bold;color: black;'>" + method + "</h7><p class='post-desc'>" + pos.TahiJobDescraption + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/searchjob.jpg'><img src ='Files/searchjob.jpg' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";

                            
                      
                        }
                    }
                    else if (ppp.ELTahiPostType == 3 || ppp.ELTahiPostType == 4 || ppp.ELTahiPostType == 5 || ppp.ELTahiPostType == 6|| ppp.ELTahiPostType == 7|| ppp.ELTahiPostType == 8 )
                    {
                        foreach (var pos in DB.ElTahiOtherPosts.Where(l => l.ElTahiPerantPostID == ppp.ELTahiPostPerantID))
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
                            }




                            //method = "Company :" + pos. + "</br>" + "Workplace :" + pos.TahiJobWorkplace + "</br>" + "Job Location :" + pos.TahiJobLocation + "</br>" + "Job Type :" + pos.TahiJobType + "</br>" + "Description :";
                            if (ppp.ELTahiPostType == 5)
                            {
                                postview.InnerHtml += "<div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '#' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'jobdetail.aspx?RecID=" + pos.ElTahiOtherPostsID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiOtherPostTitle + "</h7><br><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiProvideAdvice + "</h7><p class='post-desc'>" + pos.ElTahiotherPostDetail + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pos.ElTahiOtherPostImageURL + "'><img src ='Files/" + pos.ElTahiOtherPostImageURL + "' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";

                            }
                            else
                            {
                                postview.InnerHtml += "<div class='card' ><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '#' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'jobdetail.aspx?RecID=" + pos.ElTahiOtherPostsID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiOtherPostTitle + "</h7><br><p class='post-desc'>" + pos.ElTahiotherPostDetail + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pos.ElTahiOtherPostImageURL + "'><img src ='Files/" + pos.ElTahiOtherPostImageURL + "' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";
                            }


                        }
                    }
                }
            }

        }
    }
}