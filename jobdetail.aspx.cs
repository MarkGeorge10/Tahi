using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class jobdetail : System.Web.UI.Page
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
                foreach (var pos in DB.ELTahiJobPosts.Where(k => k.TahiJobPostID == recid).ToList())
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
                        foreach (var pjob in DB.ELTahiJobPosts.Where(h=>h.TahiJobPostID == recid))
                        {
                            prof.InnerHtml += " <div class='card'><div class='post-title d-flex align-items-center'><div class='profile-thumb'> <a href = '#' ><figure class='profile-thumb-middle'> <img src ='assets/images/profile/" + Url + "' alt='profile picture'> </figure> </a></div>                                <div class='posted-author'> <h6 class='author'><a href = '' > " + Name + "</a></h6><span class='post-time'>20 min ago</span></div><div class='post-settings-bar'><span></span><span></span><span></span><div class='post-settings arrow-shape'><ul><li><button>copy link to adda</button></li> <li><button>edit post</button></li> <li><button>embed adda</button></li> </ul></div></div></div>";
                            method = "Job Title :" + pjob.TahiJobTitle + "</br>" + "Company :" + pjob.TahiJobComp + "</br>" + "Workplace :" + pjob.TahiJobWorkplace + "</br>" + "Job Location :" + pjob.TahiJobLocation + "</br>" + "Job Type :" + pjob.TahiJobType + "</br>" + "Description :" ;
                            //detail.InnerHtml += "<div class='post -content'><br><h7 style='font-weight: bold;'>" + method + "</h7><p class='post-desc'>" + pjob.TahiJobDescraption + "</p></div></div>";
                            detail.InnerHtml += "<div class='post -content'><div class='post-thumb-gallery'><figure class='post-thumb img-popup'><a href ='Files/searchjob.jpg'><img src ='Files/searchjob.jpg' alt ='post image'></a> </figure></div><h5 style='font-weight: bold;'>" + method + "</h5><br><p class='post-desc'>" + pjob.TahiJobDescraption + "</p></div></div>";

                        }
                    }
                  
               
               
                }

                getSuggestions(us);
                getFollowers(us);
            }
        }

        protected void getSuggestions(int userId)
        {
            string urlImage = "";
            string suggestionName = "";
            List<int> suggestedFriend = new List<int>();
            List<int> followers = new List<int>();

            if (DB.Friendships.Where(l => l.ElTahiRequesterUserId == userId).Count() > 0)
            {
                foreach (var friend in DB.Friendships.Where(l => l.ElTahiRequesterUserId == userId).ToList())
                {
                    followers.Add(friend.ElTahiFriendUserId);
                    if (DB.Friendships.Where(l => l.ElTahiRequesterUserId == friend.ElTahiFriendUserId & friend.ElTahiFriendUserId != l.ElTahiFriendUserId).Count() > 0)
                    {
                        foreach (var friendOfFriend in DB.Friendships.Where(l => l.ElTahiRequesterUserId == friend.ElTahiFriendUserId & friend.ElTahiFriendUserId != l.ElTahiFriendUserId).ToList())
                        {

                            if (friend.ElTahiRequesterUserId != friendOfFriend.ElTahiFriendUserId)
                            {
                                suggestedFriend.Add(friendOfFriend.ElTahiFriendUserId);

                            }


                        }

                    }





                }

                foreach (var suggest in suggestedFriend.Except(followers).ToList())
                {
                    foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == suggest))
                    {
                        suggestionName = per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName;
                    }
                    foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == suggest))
                    {
                        if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == suggest).Count() > 0)
                        {
                            urlImage = persimg.ElTahiProfileImageName;

                        }
                        else
                        {
                            urlImage = "profile-1.jpg' ";
                        }
                    }

                    suggestionJobDetailsBodyItem.Text += "<li class='unorder-list'><div class='profile-thumb'><a href='FollowerProfilePage.aspx?uid=" + suggest + "'><figure class='profile-thumb-small'><img src='assets/images/profile/" + urlImage + "' alt='profile picture'></figure></a></div><div class='unorder-list-info'><h3 class='list-title'><a href='FollowerProfilePage.aspx?uid=" + suggest + "'>'" + suggestionName + "'</a></h3></div></li>";

                }


            }
            else
            {

                foreach (var otherFriends in DB.ElTahiUsers.Where(l => l.ElTahiUserID != userId).ToList())
                {

                    suggestionName = otherFriends.ElTahiFirstName + " " + otherFriends.ELTahiSecondName + " " + otherFriends.ElTahiLastName;


                    foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == otherFriends.ElTahiUserID))
                    {
                        if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == otherFriends.ElTahiUserID).Count() > 0)
                        {
                            urlImage = persimg.ElTahiProfileImageName;

                        }
                        else
                        {
                            urlImage = "profile-1.jpg' ";
                        }


                    }
                    suggestionJobDetailsBodyItem.Text += "<li class='unorder-list'><div class='profile-thumb'><a href='FollowerProfilePage.aspx?uid=" + otherFriends.ElTahiUserID + "'><figure class='profile-thumb-small'><img src='assets/images/profile/" + urlImage + "' alt='profile picture'></figure></a></div><div class='unorder-list-info'><h3 class='list-title'><a href='FollowerProfilePage.aspx?uid=" + otherFriends.ElTahiUserID + "'>'" + suggestionName + "'</a></h3></div></li>";

                }
            }


        }

        protected void getFollowers(int requestorId)
        {
            string Name = "";
            string Url = "";
            foreach (var friend in DB.Friendships.Where(l => l.ElTahiRequesterUserId == requestorId).ToList())
            {


                if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == friend.ElTahiFriendUserId).Count() > 0)
                {

                    foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == friend.ElTahiFriendUserId))
                    {

                        Url = persimg.ElTahiProfileImageName;



                    }
                }
                else
                {
                    Url = "profile-1.jpg' ";
                }

                foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == friend.ElTahiFriendUserId))
                {
                    Name = per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName;
                    Console.WriteLine(Name);

                }
                FollowerJobDetailsBodyItem.Text += "<li class='unorder-list'><div class='profile-thumb'><a href=FollowerProfilePage.aspx?uid=" + friend.ElTahiFriendUserId + "><figure class='profile-thumb-small'><img src='assets/images/profile/" + Url + "' alt='profile picture'></figure></a></div><div class='unorder-list-info'><h3 class='list-title'><a href='FollowerProfilePage.aspx?uid=" + friend.ElTahiFriendUserId + "'>" + Name + "</a></h3></div></li>";






            }
        }
    }
}
