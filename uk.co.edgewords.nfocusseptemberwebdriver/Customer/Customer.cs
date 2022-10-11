using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.Customer
{
    internal class Customer
    {
        //private class fields stored
        private static string s_firstName;
        private static string s_lastName;
        private static string s_streetAddress;
        private static string s_town;
        private static string s_postcode;
        private static long s_phone;
        private static string s_email;

        //Constructor for this class
        public Customer(string firstName, string lastName, string streetName,
            string town, string postcode, string phone, string email)
        {
            s_firstName = firstName;
            s_lastName = lastName;
            s_streetAddress = streetName;
            s_town = town;
            s_postcode = postcode;
            s_email = email;
            try
            {
                s_phone = long.Parse(phone);  //converting long to string
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("You might have accidentally provided either a " +
                    "special character, or an alphabet, or a space between your number." +
                    " Please review your entry.");
            }
        }

        public string GetFirstName() //returns values stored in private field
        {
            return s_firstName;
        }

        public string GetLastName()
        {
            return s_lastName;
        }

        public string GetStreetAddress()
        {
            return s_streetAddress;
        }

        public string GetTown()
        {
            return s_town;
        }

        public string GetPostcode()
        {
            return s_postcode;
        }

        public long GetPhone()
        {
            return s_phone;
        }

        public string GetEmail()
        {
            return s_email;
        }
    }
}