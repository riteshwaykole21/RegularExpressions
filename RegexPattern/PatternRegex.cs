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
    }
}
