using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _21487822_HW04.Models
{
    public class UserDonation : UserDetail
    {

        public int mDonateAmount { get; set; }

        public UserDonation(string name, string surname, int age, string email, int donationAmount) : base(name, surname, age, email)
        {
            mDonateAmount = donationAmount;
        }

        public UserDonation(string name, string surname, int age, string email) : base(name, surname, age, email)
        {

        }
    }
}