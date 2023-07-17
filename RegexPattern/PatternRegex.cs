using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class PatternRegex
    { 
        public void ValidateFirstName(string name)
        {
            string firstname = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, firstname))
            {
                Console.WriteLine("First Name is Matching With Regex");
            }
            else
            {
                Console.WriteLine("The Name Is Not Match With Regex");
            }
        }
        public void ValidateLastName(string name)
        {
            string Lastname = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, Lastname))
            {
                Console.WriteLine("Last Name is Matching With Regex");
            }
            else
            {
                Console.WriteLine("The Name Is Not Match With Regex");
            }
        }
        public void ValidateEmailID(string name)
        {
            string EmaiID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(name, EmaiID))
            {
                Console.WriteLine("EmailId is Matching With Regex");
            }
            else
            {
                Console.WriteLine("The Email Is Not Match With Regex");
            }
        }
        public void ValidatePhoneNo(string name)
        {
            string PhoneNo = "^[0-9]{2}[  ][0-9]{10}$";
            if (Regex.IsMatch(name, PhoneNo))
            {
                Console.WriteLine("PhoneNo is Matching With Regex");
            }
            else
            {
                Console.WriteLine("The PhoneNo Is Not Match With Regex");
            }
        }
    }
}

