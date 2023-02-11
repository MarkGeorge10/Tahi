using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tahi
{
    public partial class signup : System.Web.UI.Page
    {
         db_a8d12b_amahmyEntities DB = new  db_a8d12b_amahmyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCrtacc_Click(object sender, EventArgs e)
        {
            DB.ElTahiUsers.Add(new ElTahiUser {
                ElTahiFirstName = TxtFName.Text,
                ELTahiSecondName = TextSName.Text,
                ElTahiLastName = TxtLName.Text,
                ElTahiUserEmail = TxtEmal.Text,
                ElTahiUserMobile = TxtMobile.Text,
                ElTahiUserBio = TxtBio.Text,
                ElTahiUserBirthdate = DateTime.Parse(TxtBdate.Text),
                ELTahiUserName = TxtUserName.Text,
                ElTahiUserPassWord = TxtPassword.Text,
                ElTahiUserTypeID = int.Parse(DdlTyp.SelectedValue),
                ELTahiNationalID = int.Parse(DdlNationalty.SelectedValue),
                ELTahiUserCountryID = int.Parse(DDlCountry.SelectedValue)

            });
            DB.SaveChanges();
            Response.Redirect("~/Home.aspx");

        }

        //protected void Btnlogin_Click(object sender, EventArgs e)
        //{
        //    if (DB.ElTahiUsers.Where(k => k.ElTahiUserEmail == Txtuslog.Text && k.ElTahiUserPassWord == Txtlogpass.Text).Count() > 0)
        //    {
               
        //            var link = DB.ElTahiUsers.Where(k => k.ElTahiUserEmail == Txtuslog.Text && k.ElTahiUserPassWord == Txtlogpass.Text).ToList();
        //            foreach (var us in link)
        //            {
        //                if (us.ElTahiUserTypeID == 1)
        //                {
        //                    Session["UserID"] = us.ElTahiUserID;
        //                    Session["CompID"] = us.ELTahiUserName;
        //                    Session["Role"] = us.ElTahiUserTypeID;

        //                    Response.Redirect("~/wall.aspx?ResID=" + us.ElTahiUserID + "");
        //                }
        //                else
        //                {
        //                    if (DB.TahiSupInformations.Where(o => o.tahiSupUserID == us.ElTahiUserID).Count() > 0)

        //                    {
        //                        Session["UserID"] = us.ElTahiUserID;
        //                        Session["CompID"] = us.ELTahiUserName;
        //                        Session["Role"] = us.ElTahiUserTypeID;
        //                        Response.Redirect("~/WallX.aspx?ResID=" + us.ElTahiUserID + "");
        //                    }
        //                    else
        //                    {
        //                        Session["UserID"] = us.ElTahiUserID;
        //                        Session["CompID"] = us.ELTahiUserName;
        //                        Session["Role"] = us.ElTahiUserTypeID;
        //                        Response.Redirect("~/supplierinfo.aspx?ResID=" + us.ElTahiUserID + "");


        //                    }
        //                }
        //            }
        //        }
            
           
        //}
    

        protected void DdlTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlTyp.SelectedIndex == 0)
            {
                Rusttyp.Visible = false;
                    Rstsuplname.Visible = false;
                address.Visible = false;
            }
            else if (DdlTyp.SelectedIndex == 1)
            {
                Rusttyp.Visible = false;
                Rstsuplname.Visible = true;
                address.Visible = true;

            }
            else if (DdlTyp.SelectedIndex == 2)
            {
                Rusttyp.Visible = true;
                Rstsuplname.Visible = true;
                address.Visible = true;
            }
        }
    }
}