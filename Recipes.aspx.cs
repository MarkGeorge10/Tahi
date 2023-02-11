using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class Recipes : System.Web.UI.Page
    {

        db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
        string personalUserid;
        string comid;
        int maxpost;
        int recipepostm;
        protected void Page_Load(object sender, EventArgs e)
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
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
               
                int ingr = int.Parse(DDLing.SelectedValue);
                int postid = int.Parse(Label1.Text);
                int Reguser = int.Parse(Session["UserID"].ToString());
                int id;
                int idperant;
                if (Session["Recipid"] == null || Session["Recipid"].ToString() != Label3.Text)
                {
                    DB.ELTahiPerantPosts.Add(new ELTahiPerantPost
                    {
                        ElTahiPostRegDT = DateTime.Now,
                        ElTahiPostUserID = Reguser,
                        ELTahiPostType =1 ,

                    });
                    DB.SaveChanges();
                    idperant = DB.ELTahiPerantPosts.Max(p => p.ELTahiPostPerantID);

                    DB.ElTahiRescipePosts.Add(new ElTahiRescipePost
                    {
                        ElTahiRecipePostHeader = txtheader.Text,
                        ElTahiRecipePostBody = txtarea.Text,
                        ELTahiRecipePostRegDT = DateTime.Now,
                        ElTahiRecipePostUserID = Reguser,
                        ElTahiRecipePostStatusID = 3,
                        ElTahiPerentPostID=idperant,

                    });
                    DB.SaveChanges();
                    var iddd = DB.ElTahiRescipePosts.Max(p => p.ElTahiRecipePostID);
                    //var iddd =DB.ElTahiRescipePosts.OrderBy(m => m.ElTahiRecipePostID).LastOrDefault();
                     id = DB.ElTahiRescipePosts.Max(p => p.ElTahiRecipePostID);
                    Label3.Text = id.ToString();
                    Session["Recipid"] = id.ToString();
                    DB.ElTahiRecipePostMethods.Add(new ElTahiRecipePostMethod
                    {
                        ElTahiRecipePostID = id,
                        ElTahiCuisineID = int.Parse(DDLCuisni.SelectedValue),
                        ElTahiCookingMethodID = int.Parse(DDlCook.SelectedValue),
                        ElTahiRecipeTypeID = int.Parse(DDLRecTyp.SelectedValue),

                    });
                    DB.SaveChanges();
                    recipepostm = DB.ElTahiRecipePostMethods.Max(m => m.ElTahiRecipePostMethodID);
                    string folderPath = Server.MapPath("~/Files/");

                    //Check whether Directory (Folder) exists.
                    if (!Directory.Exists(folderPath))
                    {
                        //If Directory (Folder) does not exists Create it.
                        Directory.CreateDirectory(folderPath);
                    }
                    //Save the File to the Directory (Folder).
                    if (fileup.HasFile)
                    {
                        fileup.SaveAs(folderPath + Path.GetFileName(fileup.FileName));

                        //Display the Picture in Image control.
                        Image1.ImageUrl = "~/Files/" + Path.GetFileName(fileup.FileName);
                        DB.ElTahiPostImages.Add(new ElTahiPostImage
                        {
                            ElTahiPostImageURL = Path.GetFileName(fileup.FileName),
                            ElTahiPostImageRegDT = DateTime.Now,
                            ElTahiPostImageUserID = Reguser,
                            ElTahiPostImageStatusID = 4,
                        });
                        DB.SaveChanges();
                        int imgpos = DB.ElTahiPostImages.Max(m => m.ElTahiPostImageID);
                        //= posImg.ElTahiPostImageID;
                        DB.ElTahiRecipePostImagesRelations.Add(new ElTahiRecipePostImagesRelation
                        {
                            ElTahiRecipePostID = id,
                            ElTahiPostImageID = imgpos,
                            ElTahiRelationRegDT = DateTime.Now,
                            ElTahiRelationRegUserID = Reguser,

                        });
                        DB.SaveChanges();
                    }
                }
                DB.ElTahiPostRecipIngradients.Add(new ElTahiPostRecipIngradient
                {
                    ElTahiPostRecipIngrName = DDLing.SelectedItem.Text,
                    ELTahiPostUserID = Reguser,
                    ElTahiPostRecipWight = Txtingwight.Text,
                    ElTahiPostingradientID = ingr,
                    ElTahiRecipePostID = int.Parse(Label3.Text),
                    ELTahiPostWightUnit = ddlunit.SelectedValue,
                    ElTahiRecipeIngDetails = TxtIngDesc.Text,
                });
                DB.SaveChanges();
             

               
                GridView1.DataBind();
            }
           
        }

        protected void AddSupRec_Click(object sender, EventArgs e)
        {
            int Reguser = int.Parse(Session["UserID"].ToString());
            //int subid =int.Parse( Label2.Text);
            //var result = DB.ElTahiSupRescipePosts.SingleOrDefault(b => b.ElTahiSubRecipePostID == subid);
            lblsupresname.Text = TxtSubRecipeName.Text;
         
                int ingrsub = int.Parse(DDlSubRecing.SelectedValue);
                int postid = int.Parse(Label1.Text);
               // int Reguser = int.Parse(Session["UserID"].ToString());
                DB.ElTahiSupRescipePosts.Add(new ElTahiSupRescipePost
                {
                    ElTahiRecipePostHeader = TxtSubRecipeName.Text,
                    ElTahiRecipePostBody = txtSubDir.Text,
                    ElTahiRecipePostID = int.Parse(Label1.Text),
                    ELTahiRecipePostRegDT = DateTime.Now,
                    ElTahiRecipePostUserID = Reguser,
                    ElTahiRecipePostStatusID = 3,

                });

                DB.SaveChanges();
                GVsubrec.DataBind();
                Label4.Text = DB.ElTahiSupRescipePosts.Max(p => p.ElTahiSubRecipePostID).ToString();

           

        }

        protected void btnSubRecIng_Click(object sender, EventArgs e)
        {
            int ingrsub = int.Parse(DDlSubRecing.SelectedValue);
            int postid = int.Parse(Label1.Text);
            int Reguser = int.Parse(Session["UserID"].ToString());
           int subid =int.Parse( Label4.Text);
           var result = DB.ElTahiSupRescipePosts.SingleOrDefault(b => b.ElTahiSubRecipePostID == subid);

            if (result != null)
            {
                result.ElTahiRecipePostHeader = TxtSubRecipeName.Text;
                result.ElTahiRecipePostBody = txtSubDir.Text;
                result.ElTahiRecipePostID = int.Parse(Label1.Text);
                result.ELTahiRecipePostRegDT = DateTime.Now;
                result.ElTahiRecipePostUserID = Reguser;
                result.ElTahiRecipePostStatusID = 3;
                DB.SaveChanges();
            }
   
            DB.ElTahiSubRecipePostIngradients.Add(new ElTahiSubRecipePostIngradient
            {
                ElTahiPostRecipIngrName = DDlSubRecing.SelectedItem.Text,
                ELTahiPostUserID = Reguser,
                ElTahiPostRecipWight = TxtSubIngWight.Text,
                ElTahiPostingradientID = ingrsub,
                ElTahiRecipePostID = int.Parse(Label1.Text),
                ElTahiSubRecipePostID = int.Parse(Label4.Text),
                ElTahSubResIngDetails = TxtSubIngDesc.Text,
                ELTahiPostWightUnit = DDLSubUnit.SelectedValue,
                 //= TxtIngDesc.Text,
            });
            DB.SaveChanges();
            GridView2.DataBind();
        }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            int Reguser = int.Parse(Session["UserID"].ToString());
            int subid = int.Parse(Label1.Text);
            var result1 = DB.ElTahiRescipePosts.SingleOrDefault(b => b.ElTahiRecipePostID == subid);
            if (result1 != null)
            {
                result1.ElTahiRecipePostHeader = txtheader.Text;
                result1.ElTahiRecipePostBody = txtarea.Text;
                result1.ElTahiRecipePostUpdateDT = DateTime.Now;
                result1.ElTahiRecipePostUserID = Reguser;
                result1.ElTahiRecipePostStatusID = 4;
              
                DB.SaveChanges();
            }
            var result2 = DB.ElTahiRecipePostMethods.SingleOrDefault(b => b.ElTahiRecipePostMethodID == recipepostm);
            if (result2 != null)
            {
                result2.ElTahiRecipePostID = int.Parse( Label1.Text);
                result2.ElTahiCuisineID = int.Parse(DDLCuisni.SelectedValue);
                result2.ElTahiCookingMethodID = int.Parse(DDlCook.SelectedValue);
                result2.ElTahiRecipeTypeID = int.Parse(DDLRecTyp.SelectedValue);

                DB.SaveChanges();
            }
       

        }
        

        //protected void btnAddstep_Click(object sender, EventArgs e)
        //{
        //    if (Session["UserID"] != null)
        //    {
        //        int ingr = int.Parse(DDLing.SelectedValue);
        //        int postid = int.Parse(Label1.Text);
        //        int Reguser = int.Parse(Session["UserID"].ToString());
        //        int postRec = DB.ElTahiPostRecips.Max(p => p.ELTahiPostRecipID);
        //        int postRecipe = postRec + 1;
        //        DB.ElTahiPostRecSteps.Add(new ElTahiPostRecStep
        //        {
        //            ElTahiPostRecipID = postRecipe,
        //            ELTahiUserID = Reguser,
        //            ElTahiPostRecStep1 = txtarea.Text,
        //            ElTahiPostID = postid,
        //        });
        //        DB.SaveChanges();

        //        GridView2.DataBind();
        //    }
        //}
    }
}