using System;
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
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    PatternRegex Pattern = new PatternRegex();
                    Pattern.ValidateFirstName("Ritesh");
                    break;
            }
            Console.ReadLine();
        }
    }
}
