using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beck3
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: "); 
            string fname = Console.ReadLine(); // 
            Console.WriteLine("Please enter your last name: "); 
            string lname = Console.ReadLine(); 
            string fullname = StringOperations.CapitalizeName(fname, lname); 
            Console.WriteLine("Your full name with first letters capitalized is: " + fullname);
            Console.ReadKey();
        }
        public static string CapitalizeName(string fname, string lname)
        {
            string cfname = fname.First().ToString().ToUpper() + fname.Substring(1);
            string clname = lname.First().ToString().ToUpper() + lname.Substring(1);
            string cfullname = cfname + " " + clname;
            return cfullname;
        }



    }
}
