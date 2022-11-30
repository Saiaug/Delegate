using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program
    {
        public delegate string NewDelegate(string str);
      public static void Main(string[] args)
        {
           string strl;
            //string t;
            Console.Write("Input the string : ");
            strl = Console.ReadLine();
           
            
             NewDelegate d1 = new NewDelegate(OnWord);
             NewDelegate d2 = new NewDelegate(OnNumber);
             NewDelegate d3 = new NewDelegate(OnJunk);
            //string str = d1.Invoke("123");
            //string str1 = d2.Invoke("123");
            //string str2 = d3.Invoke("123");
            //NewDelegate multicastDelegate = (NewDelegate)NewDelegate.Combine(d1, d2, d3);
            //multicastDelegate.Invoke();
            // NewDelegate d1 = new NewDelegate(OnWord);
            //Console.Write("The string is present");
            d1(strl) ;
            d2(strl);
            d3(strl);
            // Console.Write(t);
            //Console.Read();
        }


        public static string OnWord(string str)
        {
            /* foreach (char c in str)
             {
                 if (Char.IsLetterOrDigit(c))
                 {
                     Console.WriteLine("The string is alphanumeric number");
                     Console.Read();
                 }*/
            if (Regex.IsMatch(str, "^[a-zA-Z0-9]*$")  && !Regex.IsMatch(str, @"^\d+$"))
            {
                Console.WriteLine("The string is aplhanumeric number");
                Console.Read();

            }

            return str;


        }

        public static string OnNumber(string str)
        {

            if (Regex.IsMatch(str, @"^\d+$"))
            {
                Console.WriteLine("The string is number");
                Console.Read();

            }


            return str;
        

        }

        public static string OnJunk(string str)
        {

            if (!Regex.IsMatch(str, @"^[a-zA-Z0-9]+$"))
            {

                Console.WriteLine("The string is neither alphabet nor number");
                Console.Read();

            }

            return str;


        }

       /* public static string Run(string t)
        {
            Console.WriteLine(("Input the string: "));
            Console.ReadLine();
            return t;

           



        }*/


    }
}
