using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _21487822_HW04.Models
{
    public abstract class UserDetail
    {
       //Assign field and properties
        public string mName { get; set; }
        public string mSurname { get; set; }
        public int mAge { get; set; }
        public string mEmail { get; set; }

        public UserDetail() { }
        //constructor that takes multiple arguments
        protected UserDetail(string name, string surname, int age, string email)
        {
            mName = name;
            mSurname = surname;
            mAge = age;
            mEmail = email;


        }

        public virtual string MEssage()
        {
            return this.mName + "" + this.mSurname;
        }
    }
}