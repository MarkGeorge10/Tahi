using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class RecipDetailView : System.Web.UI.Page
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
                foreach (var pos in DB.ElTahiRescipePosts.Where(k => k.ElTahiRecipePostID ==recid ).ToList())
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
                            prof.InnerHtml = " <div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div>";
                            detail.InnerHtml+= "<div class='post -content'><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/" + pimg.ElTahiPostImageURL + "'><img src ='Files/" + pimg.ElTahiPostImageURL + "' alt ='post image'></a> </figure></div><h5 style='font-weight: bold;'>" + pos.ElTahiRecipePostHeader + "</h5><br><h7 style='font-weight: bold;'>" + method + "</h7><p class='post-desc'>" + pos.ElTahiRecipePostBody + "</p></div></div>";

                        }
                    }
                    foreach (var sup in DB.ElTahiSupRescipePosts.Where(p => p.ElTahiRecipePostID == pos.ElTahiRecipePostID))
                    {
                        detail1.InnerHtml += "<div class='post-content'><h5 style='font-weight: bold;'>" + sup.ElTahiRecipePostHeader + "</h5><br><p class='post-desc'>" + sup.ElTahiRecipePostBody + "</p></div></div>";

                        foreach (var inv in DB.ElTahiSubRecipePostIngradients.Where(l => l.ElTahiSubRecipePostID == sup.ElTahiSubRecipePostID))
                        {
                            diving.InnerHtml += "<div class='cc'> "+inv.ElTahiPostRecipIngrName+ "</div><div class='cc'> " + inv.ElTahSubResIngDetails + "</div><div class='cc'> " + inv.ElTahiPostRecipWight+ "</div><div class='cc'>" + inv.ELTahiPostWightUnit+ " </div>";
                        }
                    }
                }

                // viewcomment section//
                int perPos = int.Parse(DB.ElTahiRescipePosts.Where(p => p.ElTahiRecipePostID == recid).Select(o => o.ElTahiPerentPostID).SingleOrDefault().ToString());

                foreach (var pos in DB.ElTahiPostComments.Where(k => k.ELTahiPerentPostID == perPos).ToList())
                {
                    foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == pos.ELTahiUserID))
                    {
                        Name = per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName;
                    }
                    foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == pos.ELTahiUserID))
                    {
                        if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == pos.ELTahiUserID).Count() > 0)
                        {
                            Url = persimg.ElTahiProfileImageName;

                        }
                        else
                        {
                            Url = "profile-1.jpg' ";
                        }
                    }


                    divVcom.InnerHtml += " <div class='card' style='min-width: 100%'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = 'FollowerProfilePage.aspx?uid=" + pos.ELTahiUserID + "' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div><div class='posted-author'> <h6 class='author'><a href = '' > " + Name + "</a></h6><span class='post-time'>" + pos.ELTahiComRegDT + "</span></div></br><span class='post-time'>" + pos.ElTahiComment+"</span></div></div>";
                      
                    
                }

                int useridInteger = int.Parse(personalUserid);
                
                var ratingData = DB.ElTahiPostScores.Where(r=>   r.ElTahiPostID == recid && r.ElTahiUserID == useridInteger ).FirstOrDefault();


                if (ratingData != null)
                {
                    ratebtn.Visible = false;
                    // rating.Visible = false;
                    if (ratingData.ElTahiScore == 1)
                    {
                        star1.Checked = true;
                    }
                    if (ratingData.ElTahiScore == 2)
                    {
                        star2.Checked = true;
                    }

                    if (ratingData.ElTahiScore == 3)
                    {
                        star3.Checked = true;
                    }

                    if (ratingData.ElTahiScore == 4)
                    {
                        star4.Checked = true;
                    }

                    if (ratingData.ElTahiScore == 5)
                    {
                        star5.Checked = true;
                    }

                }

            }
        }

        protected void brnaddcom_Click(object sender, EventArgs e)
        {
            string QS = Request.QueryString["RecID"];
            int recid = int.Parse(QS);
          int perPos = int.Parse( DB.ElTahiRescipePosts.Where(p => p.ElTahiRecipePostID == recid).Select(o => o.ElTahiPerentPostID).SingleOrDefault().ToString());
            DB.ElTahiPostComments.Add(new ElTahiPostComment {
                ELTahiPerentPostID = perPos,
                ElTahiComment=Txtcom.Text,
                ELTahiUserID= int.Parse( personalUserid),
                ELTahiComRegDT = DateTime.Now
            });
            DB.SaveChanges();

        }

        protected void rating_Click(object sender, EventArgs e)
        {
            string QS = Request.QueryString["RecID"];
            int recid = int.Parse(QS);
            int perPos = int.Parse(DB.ElTahiRescipePosts.Where(p => p.ElTahiRecipePostID == recid).Select(o => o.ElTahiPerentPostID).SingleOrDefault().ToString());

            string rateValue = "";
            if (star1.Checked)
            {
                rateValue = star1.Text;
            }
            else if (star2.Checked)
            {
                rateValue = star2.Text;
            }
            else if (star3.Checked)
            {
                rateValue = star3.Text;
            }

            else if (star4.Checked)
            {
                rateValue = star4.Text;
            }

            else if (star5.Checked)
            {
                rateValue = star5.Text;
            }




            DB.ElTahiPostScores.Add(new ElTahiPostScore
            {


                ElTahiPostID = recid,
                ElTahiUserID = Convert.ToInt32(personalUserid),
                ElTahiScore = Convert.ToInt32(rateValue),
                ElTahiScoreRegDT = DateTime.Now


            });
            DB.SaveChanges();
            Response.Redirect("~/RecipDetailView.aspx?ResID=" + recid + "");
        }
    }
}