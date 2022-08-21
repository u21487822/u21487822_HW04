using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _21487822_HW04.Models
{
    public class CardDetails : UserDonation
    {
        // encapsulation is private to be accessed within the same class
        private int mCardNumber;
        private DateTime mExpirationDate;
        private int mCVVNumber;
        private int mSecurityCode;
        private double mAmount;


        public int CardNumber
        { get => mCardNumber; set => mCardNumber = value; }
        public DateTime ExpirationDate
        { get => mExpirationDate; set => mExpirationDate = value; }
        public int CVVNumber
        { get => mCVVNumber; set => mCVVNumber = value; }
        public int SecurityCode
        { get => mSecurityCode; set => mSecurityCode = value; }
        public double Amount
        { get => mAmount; set => mAmount = value; }



        public CardDetails(string name, string surname, int age, string email, int CardNumber, DateTime ExpirationDate, int CVVNumber, int SecurityCode, double Amount) : base(name, surname, age, email)
        {
            mCardNumber = CardNumber;
            mExpirationDate = ExpirationDate;
            mCVVNumber = CVVNumber;
            mSecurityCode = SecurityCode;
            mAmount = Amount;

        }

        public override string MEssage()
        {
            return base.MEssage() + "donated" + this.Amount;
        }
    }
}