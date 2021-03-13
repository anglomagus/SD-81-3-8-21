using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassPropertiesChallenge
{
    [TestClass]
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get;  }
        public DateTime BirthDate { get; set; }

        public User( string firstName, string lastName, int id, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDate = birthdate;
        }

        public User()
        {

        }

    }
}
