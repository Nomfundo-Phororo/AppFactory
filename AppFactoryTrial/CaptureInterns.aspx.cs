using AppFactoryTrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppFactoryTrial
{
    public partial class InternsCapture : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

      

        protected void FirstName_TextChanged(object sender, EventArgs e)
        {
           
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void MiddleName_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Email_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void AltEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void AltPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            HumanBeing Human = new HumanBeing();
            InvolvingDB involvingDB = new InvolvingDB();
            Human.Firstname1 = FirstName.Text;
            Human.Lastname1 = Surname.Text;
            Human.Middlename1 = MiddleName.Text;

            Human.DateOfBirth1 = Calendar1.SelectedDate;
            Human.AlternateEmail1 = AltEmail.Text;
            Human.Email1 = Email.Text;
            Human.AlternateNumber1 = AltPhoneNumber.Text;
            Human.PhoneNumber1 = PhoneNumber.Text;

            if (IsbusinessEmail.Checked)
            {

                Human.IsBusiness1 = 1;
            }
            else
            {
                Human.IsBusiness1 = 0;
            }
            if (IsnoActive.Checked)
            {
                Human.IsActive1 = 1;
            }
            else
            {
                Human.IsActive1 = 0;
            }

            if (Roles.SelectedValue == "1")
            {
                Human.Role1 = 1;
            }
            else if (Roles.SelectedValue == "2")
            {
                Human.Role1 = 2;
            }
            else if (Roles.SelectedValue == "3")
            {
                Human.Role1 = 3;
            }
            involvingDB.SentToDB(Human);
          
            CleaningUp();

        }
        private void CleaningUp()
        {

            FirstName.Text = String.Empty;
            Surname.Text = String.Empty;
            MiddleName.Text = String.Empty;
            Email.Text = String.Empty;
            AltEmail.Text = String.Empty;
            PhoneNumber.Text = String.Empty;
            AltPhoneNumber.Text = String.Empty;
        }

    }
}