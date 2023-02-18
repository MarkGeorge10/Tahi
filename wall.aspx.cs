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

                    
                    // post type 1 that is means Rescipe post
                    if (ppp.ELTahiPostType == 1)
                    {
                        foreach (var pos in DB.ElTahiRescipePosts.Where(j => j.ElTahiPerentPostID == ppp.ELTahiPostPerantID))
                        {
                            int uid = int.Parse(personalUserid);
                            var ratingList = DB.ElTahiPostScores.Where(r => r.ElTahiPostID == pos.ElTahiRecipePostID && r.ElTahiUserID == uid).ToList() ;
                            string totalReviews = ratingList.Count().ToString();
                          
                            int sum = 0;
                            double totalRate = 0.0;
                            foreach (var rate in ratingList)
                            {
                                sum +=  rate.ElTahiScore.Value;
                            }

                            if (ratingList.Count() != 0)
                            {
                                totalRate = sum / ratingList.Count();
                            }
                            else {
                                totalRate = 0.0;
                            }



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
                                    //<a href = 'RecipDetailView.aspx?RecID=" + pos.ElTahiRecipePostID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiRecipePostHeader + "</h7><br><h7 style='font-weight: bold;color: black;'>" + method + "</h7><p class='post-desc'>" + pos.ElTahiRecipePostBody + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pimg.ElTahiPostImageURL + "'><img src ='Files/" + pimg.ElTahiPostImageURL + "' alt ='post image'></a>
                                    //postview.InnerHtml += "<div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = 'profile.html' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'RecipDetailView.aspx?RecID=" + pos.ElTahiRecipePostID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiRecipePostHeader + "</h7><br><h7 style='font-weight: bold;color: black;'>" + method + "</h7><p class='post-desc'>" + pos.ElTahiRecipePostBody + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pimg.ElTahiPostImageURL + "'><img src ='Files/" + pimg.ElTahiPostImageURL + "' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";
                                    postview.InnerHtml += "<div class='card'><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li><li><button>edit post</button></li><li><button>embed adda</button></li></ul></div></div><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href='Files/" + pimg.ElTahiPostImageURL + "'><img src='Files/" + pimg.ElTahiPostImageURL + "' alt='post image'/></a></figure></div><a href='RecipDetailView.aspx?RecID=" + pos.ElTahiRecipePostID + "'><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiRecipePostHeader + "</h7><br><p class='post-desc'>" + pos.ElTahiRecipePostBody + "</p></div></a><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>201 like</span><strong>201</strong></button><button class='post-meta-like'><i class='bi bi-chat-bubble'></i><span> 41</span></button><button class='post-meta-like'><i class='bi bi-share'></i><span> 07 </span ></button><ul class='comment-share-meta'><li><div class='row'><button class='post-share'><svg style = 'color: #f3da35' width='20' height='20' viewBox='0 0 15 15' fill='none' xmlns='http://www.w3.org/2000/svg'> <path d = 'M7.22303 0.665992C7.32551 0.419604 7.67454 0.419604 7.77702 0.665992L9.41343 4.60039C9.45663 4.70426 9.55432 4.77523 9.66645 4.78422L13.914 5.12475C14.18 5.14607 14.2878 5.47802 14.0852 5.65162L10.849 8.42374C10.7636 8.49692 10.7263 8.61176 10.7524 8.72118L11.7411 12.866C11.803 13.1256 11.5206 13.3308 11.2929 13.1917L7.6564 10.9705C7.5604 10.9119 7.43965 10.9119 7.34365 10.9705L3.70718 13.1917C3.47945 13.3308 3.19708 13.1256 3.25899 12.866L4.24769 8.72118C4.2738 8.61176 4.23648 8.49692 4.15105 8.42374L0.914889 5.65162C0.712228 5.47802 0.820086 5.14607 1.08608 5.12475L5.3336 4.78422C5.44573 4.77523 5.54342 4.70426 5.58662 4.60039L7.22303 0.665992Z' fill='#f3da35'></path> </svg></button><p >"+totalRate+ "</p></div></li></ul></div><div class='post-title d-flex align-items-center'><div class='profile-thumb'><a href = 'ProfileOtherUser.aspx?uid=" + ppp.ElTahiPostUserID + "'><figure class='profile-thumb-middle'><img src = 'assets/images/profile/" + Url + "' alt='profile picture'/></figure></a></div><div class='posted-author'><h6 class='author'><a href = 'ProfileOtherUser.aspx?uid=" + ppp.ElTahiPostUserID + "'>" + Name + " </a></h6 ><span class='post-time'>20 min ago</span></div></div></div>";

                                }
                            }
                        }
                    }
                    // post type 2 that is means Job post
                    else if (ppp.ELTahiPostType == 2)
                    {
                        foreach (var pos in DB.ELTahiJobPosts.Where(l => l.ElTahiPerantPostID == ppp.ELTahiPostPerantID))
                        {
                            int uid = int.Parse(personalUserid);
                            var ratingList = DB.ElTahiPostScores.Where(r => r.ElTahiPostID == pos.TahiJobUserID && r.ElTahiUserID == uid).ToList();
                            string totalReviews = ratingList.Count().ToString();

                            int sum = 0;
                            double totalRate = 0.0;
                            foreach (var rate in ratingList)
                            {
                                sum += rate.ElTahiScore.Value;
                            }

                            if (ratingList.Count() != 0)
                            {
                                totalRate = sum / ratingList.Count();
                            }
                            else
                            {
                                totalRate = 0.0;
                            }


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




                            method = "Company :" + pos.TahiJobComp + "</br>" + "Workplace :" + pos.TahiJobWorkplace + "</br>" + "Job Location :" + pos.TahiJobLocation + "</br>" + "Job Type :" + pos.TahiJobType + "</br>" + "Description :";

                            //postview.InnerHtml += "<div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '#' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'jobdetail.aspx?RecID=" + pos.TahiJobPostID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.TahiJobTitle + "</h7><br><h7 style='font-weight: bold;color: black;'>" + method + "</h7><p class='post-desc'>" + pos.TahiJobDescraption + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/searchjob.jpg'><img src ='Files/searchjob.jpg' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";
                            postview.InnerHtml += "<div class='card'><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li><li><button>edit post</button></li><li><button>embed adda</button></li></ul></div></div><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href='Files/searchjob.jpg'><img src='Files/searchjob.jpg' alt='post image'/></a></figure></div><a href='jobdetail.aspx?RecID=" + pos.TahiJobPostID + "'><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.TahiJobTitle + "</h7><br><p class='post-desc'>" + pos.TahiJobDescraption + "</p></div></a><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>201 like</span><strong>201</strong></button><button class='post-meta-like'><i class='bi bi-chat-bubble'></i><span> 41</span></button><button class='post-meta-like'><i class='bi bi-share'></i><span> 07 </span ></button><ul class='comment-share-meta'><li><div class='row'><button class='post-share'><svg style = 'color: #f3da35' width='20' height='20' viewBox='0 0 15 15' fill='none' xmlns='http://www.w3.org/2000/svg'> <path d = 'M7.22303 0.665992C7.32551 0.419604 7.67454 0.419604 7.77702 0.665992L9.41343 4.60039C9.45663 4.70426 9.55432 4.77523 9.66645 4.78422L13.914 5.12475C14.18 5.14607 14.2878 5.47802 14.0852 5.65162L10.849 8.42374C10.7636 8.49692 10.7263 8.61176 10.7524 8.72118L11.7411 12.866C11.803 13.1256 11.5206 13.3308 11.2929 13.1917L7.6564 10.9705C7.5604 10.9119 7.43965 10.9119 7.34365 10.9705L3.70718 13.1917C3.47945 13.3308 3.19708 13.1256 3.25899 12.866L4.24769 8.72118C4.2738 8.61176 4.23648 8.49692 4.15105 8.42374L0.914889 5.65162C0.712228 5.47802 0.820086 5.14607 1.08608 5.12475L5.3336 4.78422C5.44573 4.77523 5.54342 4.70426 5.58662 4.60039L7.22303 0.665992Z' fill='#f3da35'></path> </svg></button><p >" + totalRate + "</p></div></li></ul></div><div class='post-title d-flex align-items-center'><div class='profile-thumb'><a href = 'ProfileOtherUser.aspx?uid="+ ppp.ElTahiPostUserID+ "'><figure class='profile-thumb-middle'><img src = 'assets/images/profile/" + Url + "' alt='profile picture'/></figure></a></div><div class='posted-author'><h6 class='author'><a href = 'ProfileOtherUser.aspx?uid=" + ppp.ElTahiPostUserID + "'>" + Name + " </a></h6 ><span class='post-time'>20 min ago</span></div></div></div>";
                        }
                    }

                    // post type 3,4,5,6,7,8 that is means other post
                    else if (ppp.ELTahiPostType == 3 || ppp.ELTahiPostType == 4 || ppp.ELTahiPostType == 5 || ppp.ELTahiPostType == 6 || ppp.ELTahiPostType == 7 || ppp.ELTahiPostType == 8)
                    {
                        foreach (var pos in DB.ElTahiOtherPosts.Where(l => l.ElTahiPerantPostID == ppp.ELTahiPostPerantID))
                        {
                            int uid = int.Parse(personalUserid);
                            var ratingList = DB.ElTahiPostScores.Where(r => r.ElTahiPostID == pos.ElTahiOtherPostsID && r.ElTahiUserID == uid).ToList();
                            string totalReviews = ratingList.Count().ToString();

                            int sum = 0;
                            double totalRate = 0.0;
                            foreach (var rate in ratingList)
                            {
                                sum += rate.ElTahiScore.Value;
                            }

                            if (ratingList.Count() != 0)
                            {
                                totalRate = sum / ratingList.Count();
                            }
                            else
                            {
                                totalRate = 0.0;
                            }

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

                               


                                //postview.InnerHtml += "<div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '#' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'jobdetail.aspx?RecID=" + pos.ElTahiOtherPostsID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiOtherPostTitle + "</h7><br><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiProvideAdvice + "</h7><p class='post-desc'>" + pos.ElTahiotherPostDetail + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pos.ElTahiOtherPostImageURL + "'><img src ='Files/" + pos.ElTahiOtherPostImageURL + "' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";
                                postview.InnerHtml += "<div class='card'><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li><li><button>edit post</button></li><li><button>embed adda</button></li></ul></div></div><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href='Files/" + pos.ElTahiOtherPostImageURL + "'><img src='assets/images/profile/" + Url + "' alt='post image'/></a></figure></div><a href='jobdetail.aspx?RecID=" + pos.ElTahiOtherPostsID + "'><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiOtherPostTitle + "</h7><br><p class='post-desc'>" + pos.ElTahiotherPostDetail + "</p></div></a><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>201 like</span><strong>201</strong></button><button class='post-meta-like'><i class='bi bi-chat-bubble'></i><span> 41</span></button><button class='post-meta-like'><i class='bi bi-share'></i><span> 07 </span ></button><ul class='comment-share-meta'><li><div class='row'><button class='post-share'><svg style = 'color: #f3da35' width='20' height='20' viewBox='0 0 15 15' fill='none' xmlns='http://www.w3.org/2000/svg'> <path d = 'M7.22303 0.665992C7.32551 0.419604 7.67454 0.419604 7.77702 0.665992L9.41343 4.60039C9.45663 4.70426 9.55432 4.77523 9.66645 4.78422L13.914 5.12475C14.18 5.14607 14.2878 5.47802 14.0852 5.65162L10.849 8.42374C10.7636 8.49692 10.7263 8.61176 10.7524 8.72118L11.7411 12.866C11.803 13.1256 11.5206 13.3308 11.2929 13.1917L7.6564 10.9705C7.5604 10.9119 7.43965 10.9119 7.34365 10.9705L3.70718 13.1917C3.47945 13.3308 3.19708 13.1256 3.25899 12.866L4.24769 8.72118C4.2738 8.61176 4.23648 8.49692 4.15105 8.42374L0.914889 5.65162C0.712228 5.47802 0.820086 5.14607 1.08608 5.12475L5.3336 4.78422C5.44573 4.77523 5.54342 4.70426 5.58662 4.60039L7.22303 0.665992Z' fill='#f3da35'></path> </svg></button><p >" + totalRate + "</p></div></li></ul></div><div class='post-title d-flex align-items-center'><div class='profile-thumb'><a href = 'ProfileOtherUser.aspx?uid=" + ppp.ElTahiPostUserID + "'><figure class='profile-thumb-middle'><img src = 'assets/images/profile/" + Url + "' alt='profile picture'/></figure></a></div><div class='posted-author'><h6 class='author'><a href = 'ProfileOtherUser.aspx?uid=" + ppp.ElTahiPostUserID + "'> " + Name + " </a></h6 ><span class='post-time'>20 min ago</span></div></div></div>";


                            }
                            else
                            {
                                //postview.InnerHtml += "<div class='card' ><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '#' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div><a href = 'jobdetail.aspx?RecID=" + pos.ElTahiOtherPostsID + "' ><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiOtherPostTitle + "</h7><br><p class='post-desc'>" + pos.ElTahiotherPostDetail + "</p><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pos.ElTahiOtherPostImageURL + "'><img src ='Files/" + pos.ElTahiOtherPostImageURL + "' alt ='post image'></a></a></figure></div><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>You and 201 people like this</span><strong>201</strong></button><ul class='comment-share-meta'><li><button class='post-comment'><i class='bi bi-chat-bubble'></i><span>41</span></button></li><li><button class='post-share'><i class='bi bi-share'></i><span>07</span></button> </li></ul></div></div></div>";
                                postview.InnerHtml +=  "<div class='card'><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li><li><button>edit post</button></li><li><button>embed adda</button></li></ul></div></div><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href='Files/" + pos.ElTahiOtherPostImageURL + "'><img src='assets/images/profile/" + Url + "' alt='post image'/></a></figure></div><a href='jobdetail.aspx?RecID=" + pos.ElTahiOtherPostsID + "'><div class='post -content'><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiOtherPostTitle + "</h7><br><h7 style='font-weight: bold;color: black;'>" + pos.ElTahiProvideAdvice + "</h7><p class='post-desc'>" + pos.ElTahiotherPostDetail + "</p></div></a><div class='post-meta'><button class='post-meta-like'><i class='bi bi-heart-beat'></i><span>201 like</span><strong>201</strong></button><button class='post-meta-like'><i class='bi bi-chat-bubble'></i><span> 41</span></button><button class='post-meta-like'><i class='bi bi-share'></i><span> 07 </span ></button><ul class='comment-share-meta'><li><div class='row'><button class='post-share'><svg style = 'color: #f3da35' width='20' height='20' viewBox='0 0 15 15' fill='none' xmlns='http://www.w3.org/2000/svg'> <path d = 'M7.22303 0.665992C7.32551 0.419604 7.67454 0.419604 7.77702 0.665992L9.41343 4.60039C9.45663 4.70426 9.55432 4.77523 9.66645 4.78422L13.914 5.12475C14.18 5.14607 14.2878 5.47802 14.0852 5.65162L10.849 8.42374C10.7636 8.49692 10.7263 8.61176 10.7524 8.72118L11.7411 12.866C11.803 13.1256 11.5206 13.3308 11.2929 13.1917L7.6564 10.9705C7.5604 10.9119 7.43965 10.9119 7.34365 10.9705L3.70718 13.1917C3.47945 13.3308 3.19708 13.1256 3.25899 12.866L4.24769 8.72118C4.2738 8.61176 4.23648 8.49692 4.15105 8.42374L0.914889 5.65162C0.712228 5.47802 0.820086 5.14607 1.08608 5.12475L5.3336 4.78422C5.44573 4.77523 5.54342 4.70426 5.58662 4.60039L7.22303 0.665992Z' fill='#f3da35'></path> </svg></button><p >"+totalRate+ "</p></div></li></ul></div><div class='post-title d-flex align-items-center'><div class='profile-thumb'><a href = 'ProfileOtherUser.aspx?uid=" + ppp.ElTahiPostUserID + "'><figure class='profile-thumb-middle'><img src = 'assets/images/profile/" + Url + "' alt='profile picture'/></figure></a></div><div class='posted-author'><h6 class='author'><a href = 'ProfileOtherUser.aspx?uid=" + ppp.ElTahiPostUserID + "'> " + Name + " </a></h6 ><span class='post-time'>20 min ago</span></div></div></div>";

                            }


                        }
                    }
                }
            }

        }
    }
}