﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class FollowerProfilePage : System.Web.UI.Page
    {

        db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
        string Name;
        string Url;
        protected void Page_Load(object sender, EventArgs e)
        {

            string otherUserId = Request.QueryString["uid"];
            int friendUserId = int.Parse(otherUserId);

            string personalUserid = Session["UserID"].ToString();
            int requestorUserId = int.Parse(personalUserid);

            if (Session["UserID"] != null)
            {

                if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == friendUserId).Count() > 0)
                {
                    foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == friendUserId))
                    {



                        proimge.InnerHtml = "<figure class='profile-picture'><a href = 'profile.aspx'> <img src = 'assets/images/profile/" + persimg.ElTahiProfileImageName + "' alt = 'profile picture' style='width: 170px; height: auto;'></a></figure>";


                    }
                }
                else
                {
                    proimge.InnerHtml += "<figure class='profile-picture'><a href = 'profile.html'> <img src = 'assets/images/profile/profile-1.jpg' alt = 'profile picture'></a></figure>";
                }



                foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == friendUserId))
                {
                    persdetail.InnerHtml += "<h6 class='author'><a href='profile.html'>" + per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName + "</a></h6><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul> <li><button>copy link to Tahi</button></li><li><button>edit post</button></li><li><button>embed Tahi</button></li></ul> </div> </div> </div> <p>BirthDate : " + per.ElTahiUserBirthdate + "</p><p>Nationalty : " + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enNationality).SingleOrDefault() + "</p><p>Bio : " + per.ElTahiUserBio + "</p>";
                }


                if (DB.Friendships.Where(u => u.ElTahiFriendUserId == friendUserId & u.ElTahiRequesterUserId == requestorUserId).ToList().Count > 0)
                {

                    followBtn.Visible = false;
                    followDiv.Visible = false;

                    unFollowBtn.Visible = true;
                    unFollowDiv.Visible = true;
                }
                else
                {
                    followBtn.Visible = true;
                    followDiv.Visible = true;


                    unFollowBtn.Visible = false;
                    unFollowDiv.Visible = false;

                }



            }


               
            }


        protected void followClick(object sender, EventArgs e)
        {

            try
            {
                string personalUserid = Session["UserID"].ToString();
                int requestorUserId = int.Parse(personalUserid);

                string otherUserId = Request.QueryString["uid"];
                int friendUserId = int.Parse(otherUserId);

                DB.Friendships.Add(new Friendship
                {
                    ElTahiRequesterUserId = requestorUserId,
                    ElTahiFriendUserId = friendUserId,
                    CreatedDateTime = DateTime.Now
                });
                DB.SaveChanges();
                Response.Redirect("~/FollowerProfilePage.aspx?uid=" + friendUserId + "");
            }
            catch (Exception ex)
            {

            }
        }

        protected void unFollowClick(object sender, EventArgs e)
        {

            try
            {
                string personalUserid = Session["UserID"].ToString();
                int requestorUserId = int.Parse(personalUserid);

                string otherUserId = Request.QueryString["uid"];
                int friendUserId = int.Parse(otherUserId);

                var deletedRow = (from x in DB.Friendships

                                  where x.ElTahiFriendUserId.Equals(friendUserId) & x.ElTahiRequesterUserId.Equals(requestorUserId)
                                  select x).FirstOrDefault();

                DB.Friendships.Remove(deletedRow);



                DB.SaveChanges();

                Response.Redirect("~/FollowerProfilePage.aspx?uid=" + friendUserId + "");

            }
            catch (Exception ex)
            {

            }



        }


    }

}

