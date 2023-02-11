using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class supplierinfo : System.Web.UI.Page
    {
            db_a8d12b_amahmyEntities DB = new db_a8d12b_amahmyEntities();
            string personalUserid;
            string comid;
          //  int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["CompID"] != null)
            {


                if (!IsPostBack)
                {
                    personalUserid = Session["UserID"].ToString();
                    comid = Session["CompID"].ToString();
                    int post = DB.ElTahiRescipePosts.Max(p => p.ElTahiRecipePostID);

                    // maxpost = post + 1;
                    // Label1.Text = maxpost.ToString();
                    int us = int.Parse(personalUserid);
                    if (DB.TahiSupInformations.Where(j=>j.tahiSupUserID == us).Count() > 0)
                    {
                        foreach (var gh in DB.TahiSupInformations.Where(j => j.tahiSupUserID == us).ToList())
                        {
                            TxtName.Text = gh.tahiSupName;

                           txtjobloc.Text = gh.tahisupAddress;
                         // h.tahisupcompsize = ddlcompsize.SelectedValue,
                            txtCompanyType.Text = gh.tahicomptype;
                            txtarea.Text= gh.tahisupdescription;
                            txtIndustry.Text= gh.tahisupindustry;
                            txtPhone.Text= gh.tahisupPhone;
                            txtspe.Text = gh.tahisupSpecialities;
                            Txttag.Text= gh.tahitagline;
                            TxtWebSite.Text = gh.tahiwebsiteurl;
                            //  TahiSupInfoUpdateDT = DateTime.Now,
                            TxtYear.Text = gh.tahisupyearfounder.ToString();
                        }
                    }
                    //foreach (var per in DB.ElTahiUsers.Where(u => u.ElTahiUserID == us))
                    //{
                    //    persodata.InnerHtml += "<h4 class='widget-title'> " + per.ElTahiFirstName + " " + per.ELTahiSecondName + " " + per.ElTahiLastName + " </h4><div class='widget-body'><div class='about-author'><p>" + per.ElTahiUserBio + "</p> <ul class='author-into-list'><li><a href = '#' ><i class='bi bi-office-bag'></i>" + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enNationality).SingleOrDefault() + "</a></li> <li><a href = '#' ><i class='bi bi-home'></i>" + DB.Countries.Where(p => p.ContID == per.ELTahiNationalID).Select(o => o.country_enName).SingleOrDefault() + "</a></li> <li><a href = '#' ><i class='bi bi-location-pointer'></i>" + per.ElTahiUserBirthdate + "</a></li><li><a href = '#' ><i class='bi bi-heart-beat'></i>Travel, Swimming</a></li></ul></div></div>";
                    //}
                }

            }

        }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            personalUserid = Session["UserID"].ToString();
            int dsup = int.Parse(personalUserid);

            var result = DB.TahiSupInformations.SingleOrDefault(b => b.tahiSupUserID == dsup);

            if (result != null)
            {
                result.tahiSupName = TxtName.Text;
                result.tahiSupUserID = int.Parse(personalUserid);
                result.tahisupAddress = txtjobloc.Text;
                result.tahisupcompsize = ddlcompsize.SelectedValue;
                result.tahicomptype = txtCompanyType.Text;
                result.tahisupdescription = txtarea.Text;
                result.tahisupindustry = txtIndustry.Text;
                result.tahisupPhone = txtPhone.Text;
                result.tahisupSpecialities = txtspe.Text;
                result.tahitagline = Txttag.Text;
                result.tahiwebsiteurl = TxtWebSite.Text;
                result.TahiSupInfoUpdateDT = DateTime.Now;
                result.tahisupyearfounder = DateTime.Parse(TxtYear.Text);
                                DB.SaveChanges();

            }
            else
            {
                DB.TahiSupInformations.Add(new TahiSupInformation
                {
                    tahiSupName = TxtName.Text,
                    tahiSupUserID = int.Parse(personalUserid),
                    tahisupAddress = txtjobloc.Text,
                    tahisupcompsize = ddlcompsize.SelectedValue,
                    tahicomptype = txtCompanyType.Text,
                    tahisupdescription = txtarea.Text,
                    tahisupindustry = txtIndustry.Text,
                    tahisupPhone = txtPhone.Text,
                    tahisupSpecialities = txtspe.Text,
                    tahitagline = Txttag.Text,
                    tahiwebsiteurl = TxtWebSite.Text,
                    TahiSupInfoUpdateDT = DateTime.Now,
                    tahisupyearfounder = DateTime.Parse(TxtYear.Text),



                });
                DB.SaveChanges();
            }
        }

        protected void btnpost_Click1(object sender, EventArgs e)
        {
            personalUserid = Session["UserID"].ToString();
            DB.TahiSupInformations.Add(new TahiSupInformation
            {
                tahiSupName = TxtName.Text,
                tahiSupUserID = int.Parse(personalUserid),
                tahisupAddress = txtjobloc.Text,
                tahisupcompsize = ddlcompsize.SelectedValue,
                tahicomptype = txtCompanyType.Text,
                tahisupdescription = txtarea.Text,
                tahisupindustry = txtIndustry.Text,
                tahisupPhone = txtPhone.Text,
                tahisupSpecialities = txtspe.Text,
                tahitagline = Txttag.Text,
                tahiwebsiteurl = TxtWebSite.Text,
                TahiSupInfoUpdateDT = DateTime.Now,
                tahisupyearfounder = DateTime.Parse(TxtYear.Text),



            });
            DB.SaveChanges();

        }
    }
}