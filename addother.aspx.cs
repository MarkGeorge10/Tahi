using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class addother : System.Web.UI.Page
    {
        db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
        string QS;
        int typid;
        int id;
        string personalUserid;
        string comid;
        int maxpost;
        int recipepostm;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Article         3
            //Achivement      4
            //Advice          5
            //Service         6
            //Leasons Learned 7
            //Courses         8
            QS = Request.QueryString["posttyID"];
            typid = int.Parse(QS);
            if (QS != null)
            {
                if (Session["UserID"] != null && Session["CompID"] != null)
                {
                    if (!IsPostBack)
                    {
                        personalUserid = Session["UserID"].ToString();
                        comid = Session["CompID"].ToString();
                        int post = DB.ElTahiRescipePosts.Max(p => p.ElTahiRecipePostID);

                        maxpost = post + 1;
                        Label1.Text = maxpost.ToString();
                        int us = int.Parse(personalUserid);
                        foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == us))
                        {
                            persodata.InnerHtml += "<h4 class='widget-title'> " + per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName + " </h4><div class='widget-body'><div class='about-author'><p>" + per.ElTahiUserBio + "</p> <ul class='author-into-list'><li><a href = '#' ><i class='bi bi-office-bag'></i>" + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enNationality).SingleOrDefault() + "</a></li> <li><a href = '#' ><i class='bi bi-home'></i>" + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enName).SingleOrDefault() + "</a></li> <li><a href = '#' ><i class='bi bi-location-pointer'></i>" + per.ElTahiUserBirthdate + "</a></li><li><a href = '#' ><i class='bi bi-heart-beat'></i>Travel, Swimming</a></li></ul></div></div>";
                        }
                    }
                }
                //if (Session["UserID"] != null && Session["CompID"] != null)
                //{

                //    personalUserid = Session["UserID"].ToString();
                //    comid = Session["CompID"].ToString();

                //}
            }
            if (typid == 3)
            {
                lblposttit.Text = " Add Article ";
                //  lbljtitle.Text = " Article Title ";
                Txtjobtitle.Attributes.Add("placeholder", "Add Article Title");


            }
            else if (typid == 4)
            {
                lblposttit.Text = " Add Achivement ";
                //  lbljtitle.Text = " Article Title ";
                Txtjobtitle.Attributes.Add("placeholder", "Add Achivement Title");
            }
            else if (typid == 5)
            {
                lblposttit.Text = " Add  Advice";
                ddldiv.Visible = true;
                ddldiv.Style.Add("visibility", "visible");
                //  lbljtitle.Text = " Article Title ";
                Txtjobtitle.Attributes.Add("placeholder", "Add  Advice Title");
            }
            else if (typid == 6)
            {
                lblposttit.Text = " Add  Service";
                //  lbljtitle.Text = " Article Title ";
                Txtjobtitle.Attributes.Add("placeholder", "Add  Service Title");
            }
            else if (typid == 7)
            {
                lblposttit.Text = " Add Leasons Learned";
                //  lbljtitle.Text = "  Courses Title ";
                Txtjobtitle.Attributes.Add("placeholder", "Add Leasons Learned Title");
            }
            else if (typid == 8)
            {
                lblposttit.Text = " Add Courses";
                //  lbljtitle.Text = "  Courses Title ";
                Txtjobtitle.Attributes.Add("placeholder", "Add Courses Title");
            }
        }


        protected void btnpost_Click(object sender, EventArgs e)
        {
            if (QS != null)
            {
                int personalUserid1 = int.Parse(Session["UserID"].ToString());

                if (QS != null && typid == 3)
                {
                    DB.ELTahiPerantPosts.Add(new ELTahiPerantPost
                    {
                        ElTahiPostRegDT = DateTime.Now,
                        ElTahiPostUserID = personalUserid1,
                        ELTahiPostType = 3,

                    });
                    DB.SaveChanges();
                    id = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);
                }
                else if (QS != null && typid == 4)
                {
                    DB.ELTahiPerantPosts.Add(new ELTahiPerantPost
                    {
                        ElTahiPostRegDT = DateTime.Now,
                        ElTahiPostUserID = personalUserid1,
                        ELTahiPostType = 4,

                    });
                    DB.SaveChanges();
                    id = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);
                }
                else if (QS != null && typid == 5)
                {
                    DB.ELTahiPerantPosts.Add(new ELTahiPerantPost
                    {
                        ElTahiPostRegDT = DateTime.Now,
                        ElTahiPostUserID = personalUserid1,
                        ELTahiPostType = 5,

                    });
                    DB.SaveChanges();
                    id = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);
                }
                else if (QS != null && typid == 6)
                {
                    DB.ELTahiPerantPosts.Add(new ELTahiPerantPost
                    {
                        ElTahiPostRegDT = DateTime.Now,
                        ElTahiPostUserID = personalUserid1,
                        ELTahiPostType = 6,

                    });
                    DB.SaveChanges();
                    id = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);
                }
                else if (QS != null && typid == 7)
                {
                    DB.ELTahiPerantPosts.Add(new ELTahiPerantPost
                    {
                        ElTahiPostRegDT = DateTime.Now,
                        ElTahiPostUserID = personalUserid1,
                        ELTahiPostType = 7,

                    });
                    DB.SaveChanges();
                    id = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);
                }
                else if (QS != null && typid == 8)
                {
                    DB.ELTahiPerantPosts.Add(new ELTahiPerantPost
                    {
                        ElTahiPostRegDT = DateTime.Now,
                        ElTahiPostUserID = personalUserid1,
                        ELTahiPostType = 8,

                    });
                    DB.SaveChanges();
                    id = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);
                }
                string folderPath = Server.MapPath("~/Files/");
                if (!Directory.Exists(folderPath))
                {
                    //If Directory (Folder) does not exists Create it.
                    Directory.CreateDirectory(folderPath);
                }
                //Save the File to the Directory (Folder).
                if (fileup.HasFile)
                {
                    fileup.SaveAs(folderPath + Path.GetFileName(fileup.FileName));

                    DB.ElTahiOtherPosts.Add(new ElTahiOtherPost
                    {
                        ElTahiOtherPostTitle = Txtjobtitle.Text,
                        ElTahiotherPostDetail = txtarea.Text,
                        ElTahiOtherPostRegDT = DateTime.Now,
                        ElTahiOtherPostType = typid.ToString(),
                        ElTahiPerantPostID = id,
                        ElTahiPostUser = personalUserid1,
                        ElTahiProvideAdvice = DDLPAdvice.SelectedValue,


                    });
                    DB.SaveChanges();
                }
            }
        }
    }
}
