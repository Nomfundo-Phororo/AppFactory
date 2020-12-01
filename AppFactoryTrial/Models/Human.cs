using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AppFactoryTrial.Models
{
    public class HumanBeing
    {
        private string Firstname;
        private string Lastname;
        private string Middlename;
        private int Role;
        private DateTime DateOfBirth;
        private string Email;
        private string AlternateEmail;
        private string PhoneNumber;
        private string AlternateNumber;
        private int IsActive;
        private int IsBusiness;



        public string Firstname1 { get => Firstname; set => Firstname = value; }
        public string Lastname1 { get => Lastname; set => Lastname = value; }
        public string Middlename1 { get => Middlename; set => Middlename = value; }
        public int Role1 { get => Role; set => Role = value; }

        public string Email1 { get => Email; set => Email = value; }
        public string AlternateEmail1 { get => AlternateEmail; set => AlternateEmail = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string AlternateNumber1 { get => AlternateNumber; set => AlternateNumber = value; }
        public DateTime DateOfBirth1 { get => DateOfBirth; set => DateOfBirth = value; }
        public int IsActive1 { get => IsActive; set => IsActive = value; }
        public int IsBusiness1 { get => IsBusiness; set => IsBusiness = value; }

      


    }
}