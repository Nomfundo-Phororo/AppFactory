using AppFactoryTrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppFactoryTrial
{
    public partial class UpdateUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {

                var result = Request.QueryString.ToString();
                int a = Convert.ToInt32(result);

                InvolvingDB involvingDB = new InvolvingDB();
                HumanBeing Updatehuman = new HumanBeing();
                involvingDB.GetfromDB(Updatehuman, a);
                Label1.Text = "Hello " + Updatehuman.Firstname1 + "";



                Fname.Text = Updatehuman.Firstname1;
                LName.Text = Updatehuman.Lastname1;
                MiddleName.Text = Updatehuman.Middlename1;
                Roles.SelectedValue = $"{Updatehuman.Role1}";
                Calendar1.SelectedDate = Updatehuman.DateOfBirth1;
                email.Text = Updatehuman.Email1;
                AltEmail.Text = Updatehuman.AlternateEmail1;
                Pnumber.Text = Updatehuman.PhoneNumber1;
                AltPnumber.Text = Updatehuman.AlternateNumber1;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = Request.QueryString.ToString();
            int a = Convert.ToInt32(result); 

            HumanBeing UpdateHuman = new HumanBeing();
            InvolvingDB involvingDB = new InvolvingDB();

            UpdateHuman.Firstname1 = Fname.Text;
            UpdateHuman.Lastname1 = LName.Text;
            UpdateHuman.Middlename1 = MiddleName.Text;

            UpdateHuman.DateOfBirth1 = Calendar1.SelectedDate;
            UpdateHuman.AlternateEmail1 = AltEmail.Text;
            UpdateHuman.Email1 = email.Text;
            UpdateHuman.AlternateNumber1 = AltPnumber.Text;
            UpdateHuman.PhoneNumber1 = Pnumber.Text;

           

            if (Roles.SelectedValue == "1")
            {
                UpdateHuman.Role1 = 1;
            }
            else if (Roles.SelectedValue == "2")
            {
                UpdateHuman.Role1 = 2;
            }
            else if (Roles.SelectedValue == "3")
            {
                UpdateHuman.Role1 = 3;
            }
            involvingDB.UpdateUser(UpdateHuman, a);
            CleaningUp();

        }
        private void CleaningUp()
        {

            Fname.Text = String.Empty;
            LName.Text = String.Empty;
            MiddleName.Text = String.Empty;
            email.Text = String.Empty;
            AltEmail.Text = String.Empty;
            Pnumber.Text = String.Empty;
            AltPnumber.Text = String.Empty;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("./ViewUsers.aspx");
        }
    }
}