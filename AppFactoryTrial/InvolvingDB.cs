using AppFactoryTrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.UI.WebControls;
using Grpc.Core;

namespace AppFactoryTrial
{
    public class InvolvingDB
    {
        
        public void SentToDB(HumanBeing dataBase)
        {


            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert into Person (LastName,FirstName,MiddleName,DateofBirth,RoleID)values('" + dataBase.Lastname1 + "','" + dataBase.Firstname1 + "','" + dataBase.Middlename1 + "','" + dataBase.DateOfBirth1 + "'," + dataBase.Role1 + ");Insert into ContactDetails values('" + dataBase.Email1 + "'," + dataBase.IsBusiness1 + ",'" + dataBase.AlternateEmail1 + "','" + dataBase.PhoneNumber1 + "'," + dataBase.IsActive1 + ",'" + dataBase.AlternateNumber1 + "',SCOPE_IDENTITY())", connection);
                    command.ExecuteNonQuery();

                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }
        public void GetfromDB(HumanBeing dataBase, int ID)
        {


            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select Person.FirstName, Person.LastName, Person.MiddleName,Roles.RoleID,Person.DateofBirth,ContactDetails.Work_Email,ContactDetails.AlternateEmail,ContactDetails.PrimaryPhone_No,ContactDetails.AlternatePhone_No,Person.PersonID from Person inner join Roles on Person.RoleID = Roles.RoleID inner join ContactDetails on Person.PersonID=ContactDetails.PersonID where Person.IsActive = 1 and Person.PersonID={ID};", connection);

                    var data = command.ExecuteReader();
                    while(data.Read())
                    {
                       dataBase.Firstname1=data[0].ToString();
                        dataBase.Lastname1 = data[1].ToString();
                        dataBase.Middlename1 = data[2].ToString();
                        dataBase.Role1 = Convert.ToInt32(data[3].ToString());
                        dataBase.DateOfBirth1 = DateTime.Parse(data[4].ToString());
                        dataBase.Email1 = data[5].ToString();
                        dataBase.AlternateEmail1 = data[6].ToString();
                        dataBase.PhoneNumber1 = data[7].ToString();
                        dataBase.AlternateNumber1 = data[8].ToString();


                    }
                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }

        public void UpdateUser(HumanBeing dataBase, int ID)
        {


            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update person set LastName='" + dataBase.Lastname1 + "',FirstName='" + dataBase.Firstname1 + "',MiddleName='" + dataBase.Middlename1 + "',DateofBirth='" + dataBase.DateOfBirth1 + "',RoleID=" + dataBase.Role1 + " where PersonID=" + ID + ";UPDATE ContactDetails set Work_Email='" + dataBase.Email1 + "',AlternateEmail='" + dataBase.AlternateEmail1 + "',PrimaryPhone_No='" + dataBase.PhoneNumber1 + "',AlternatePhone_No='" + dataBase.AlternateNumber1 + "' WHERE PersonID=" + ID + ";", connection);

                   command.ExecuteNonQuery();
                    
                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }

        public void GetAllfromDB(ref Table table)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(" select Person.FirstName, Person.LastName, Person.DateofBirth,Roles.Position,Person.PersonID from Person inner join Roles on Person.RoleID = Roles.RoleID where Person.IsActive = 1; ", connection);
                    var data = command.ExecuteReader();

                    while (data.Read())
                    {
                        TableRow row = new TableRow();
                        Button Edit = new Button();
                        //Button Deletes = new Button();
                        TableCell FirstName = new TableCell();
                        TableCell LastName = new TableCell();
                        TableCell DateofBirth = new TableCell();
                        TableCell Position = new TableCell();
                        TableCell Update = new TableCell();
                        TableCell Delete = new TableCell();


                        Edit.Text = "Edit";
                        Edit.ID = data[4].ToString();
                        Edit.CssClass= "tablebutton";
                        Edit.Click += new EventHandler(Edit_Click);
                     

                        //Deletes.Text = "Delete";
                        //Deletes.ID = data[5].ToString();

                        FirstName.Text = data[0].ToString();
                        LastName.Text = data[1].ToString();
                        DateofBirth.Text = data[2].ToString();
                        Position.Text = data[3].ToString();


                        Update.Controls.Add(Edit);
                        //Delete.Controls.Add(Deletes);
                        

                        row.Cells.Add(FirstName);
                        row.Cells.Add(LastName);
                        row.Cells.Add(DateofBirth);
                        row.Cells.Add(Position);
                        row.Cells.Add(Update);
                        //row.Cells.Add(Delete);

                        table.Rows.Add(row);

                    }



                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            HttpContext.Current.Response.Redirect($"./UpdateUsers.aspx?{button.ID}");

        }
        public void GetRolesfromDB(ref Table table)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Roles;", connection);
                    var data = command.ExecuteReader();

                    while (data.Read())
                    {
                        TableRow row = new TableRow();
                        TableCell RoleID = new TableCell();
                        TableCell Role = new TableCell();
                        TableCell RoleDesc = new TableCell();


                        RoleID.Text = data[0].ToString();
                        Role.Text = data[1].ToString();
                        RoleDesc.Text = data[2].ToString();


                        row.Cells.Add(RoleID);
                        row.Cells.Add(Role);
                        row.Cells.Add(RoleDesc);

                        table.Rows.Add(row);


                    }



                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }
        public void GetInternsfromDB(ref Table table)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(" select Person.FirstName, Person.LastName, Person.DateofBirth,Roles.Position from Person inner join Roles on Person.RoleID = Roles.RoleID where Person.IsActive = 1 and Person.RoleID=1; ", connection);
                    var data = command.ExecuteReader();

                    while (data.Read())
                    {
                        TableRow row = new TableRow();
                        Button button = new Button();
                        TableCell FirstName = new TableCell();
                        TableCell LastName = new TableCell();
                        TableCell DateofBirth = new TableCell();
                        TableCell Position = new TableCell();


                        button.Text = "Edit";

                        FirstName.Text = data[0].ToString();
                        LastName.Text = data[1].ToString();
                        DateofBirth.Text = data[2].ToString();
                        Position.Text = data[3].ToString();

                        row.Cells.Add(FirstName);
                        row.Cells.Add(LastName);
                        row.Cells.Add(DateofBirth);
                        row.Cells.Add(Position);

                        table.Rows.Add(row);

                    }



                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }
        public void GetMentorsfromDB(ref Table table)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(" select Person.FirstName, Person.LastName, Person.DateofBirth,Roles.Position from Person inner join Roles on Person.RoleID = Roles.RoleID where Person.IsActive = 1 and Person.RoleID=2; ", connection);
                    var data = command.ExecuteReader();

                    while (data.Read())
                    {
                        TableRow row = new TableRow();
                        Button button = new Button();
                        TableCell FirstName = new TableCell();
                        TableCell LastName = new TableCell();
                        TableCell DateofBirth = new TableCell();
                        TableCell Position = new TableCell();
                        TableCell Action = new TableCell();


                        button.Text = "Edit";

                        FirstName.Text = data[0].ToString();
                        LastName.Text = data[1].ToString();
                        DateofBirth.Text = data[2].ToString();
                        Position.Text = data[3].ToString();

                        row.Cells.Add(FirstName);
                        row.Cells.Add(LastName);
                        row.Cells.Add(DateofBirth);
                        row.Cells.Add(Position);
                        row.Cells.Add(Action);
                        table.Rows.Add(row);

                    }



                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }

        public void GetManagersfromDB(ref Table table)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-MD52G2CP;Initial Catalog=AppFactory;Persist Security Info=True;User ID=sa;Password=Nomfundo"))
            {

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(" select Person.FirstName, Person.LastName, Person.DateofBirth,Roles.Position from Person inner join Roles on Person.RoleID = Roles.RoleID where Person.IsActive = 1 and Person.RoleID=3; ", connection);
                    var data = command.ExecuteReader();

                    while (data.Read())
                    {
                        TableRow row = new TableRow();
                        Button button = new Button();
                        TableCell FirstName = new TableCell();
                        TableCell LastName = new TableCell();
                        TableCell DateofBirth = new TableCell();
                        TableCell Position = new TableCell();


                        button.Text = "Edit";

                        FirstName.Text = data[0].ToString();
                        LastName.Text = data[1].ToString();
                        DateofBirth.Text = data[2].ToString();
                        Position.Text = data[3].ToString();

                        row.Cells.Add(FirstName);
                        row.Cells.Add(LastName);
                        row.Cells.Add(DateofBirth);
                        row.Cells.Add(Position);

                        table.Rows.Add(row);

                    }



                }
                catch (SqlException sqlException)
                {
                    System.Diagnostics.Debug.WriteLine(sqlException);
                }
            }
        }


    }



}