using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class FriendsPage : System.Web.UI.Page 
    {
        db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
        string personalUserid;
        string Name;
        string Url;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                personalUserid = Session["UserID"].ToString();
                int requestorId = int.Parse(personalUserid);



                

                foreach (var friend in DB.Friendships.Where(l => l.ElTahiRequesterUserId == requestorId).ToList())
                {

                   
                    foreach (var persimg in DB.ElTahiProfileImages.Where(o => o.ElTahiProfileImageUserID == friend.ElTahiFriendUserId))
                    {
                        if (DB.ElTahiProfileImages.Where(p => p.ElTahiProfileImageUserID == friend.ElTahiFriendUserId).Count() > 0)
                        {
                            Url = persimg.ElTahiProfileImageName;

                        }
                        else
                        {
                            Url = "profile-1.jpg' ";
                        }

                        foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == friend.ElTahiFriendUserId))
                        {
                            Name = per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName;
                            Console.WriteLine(Name);

                            postview.InnerHtml += "<div class='card'><div class='post-meta'><div class='post-title d-flex align-items-center'><div class='profile-thumb'><a href = 'ProfileOtherUser.aspx?uid=" + friend.ElTahiFriendUserId + "'><figure class='profile-thumb-middle'><img src = 'assets/images/profile/" + Url + "' alt='profile picture'/></figure></a></div><div class='posted-author'><h6 class='author'><a href = 'ProfileOtherUser.aspx?uid=" + friend.ElTahiFriendUserId + "'> " + Name + " </a></h6 ></div></div></div>";

                        }


                    }




                }
            }

        }
    }
}