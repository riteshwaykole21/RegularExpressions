﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 :First Name");
            Console.WriteLine("2 : Last Name");
            Console.WriteLine("3 : Email Id");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    PatternRegex Pattern = new PatternRegex();
                    Pattern.ValidateFirstName("Ritesh");
                    break;
                case 2:
                    PatternRegex patternRegex = new PatternRegex();
                    patternRegex.ValidateFirstName("Ritesh");
                    patternRegex.ValidateLastName("Ritesh");
                    patternRegex.ValidateEmailID("XYZ1235@");
                    break;
                case 3:
                    PatternRegex patternRege = new PatternRegex();
                    patternRege.ValidateFirstName("Ritesh");
                    patternRege.ValidateLastName("Ritesh");
                    patternRege.ValidateEmailID("XYZ1235@");
                    break;
            }
            Console.ReadLine();
        }
    }
}
