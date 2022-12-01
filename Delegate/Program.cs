using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Delegate.Delegates;

namespace Delegate
{

    public class Delegates
    {
        public delegate string onword();

        public delegate string onnum();

        public delegate string onjunk();
    }

    public class Program
    {
       

        public static void Main(string[] args)
      {
            string strl;
            
            ConsoleReader reader = new ConsoleReader();
            onword word = new onword(reader.onword);
            onnum num = new onnum(reader.onnum);
            onjunk junk = new onjunk(reader.onjunk);

            while (true)
            {
                Console.Write("Input the string : ");
                strl = Console.ReadLine();
                reader.Run(strl, word, num, junk);

               
            }
      }


        

    }

    public class ConsoleReader
    {
        public string onword()
        {
            return "onword";
        }

        public string onnum()
        {
            return "onnum";
        }
        public string onjunk()
        {
            return "onjunk";
        }
        public void Run(string str, onword word, onnum num, onjunk junk)
        {
            if (Regex.IsMatch(str, "^[a-zA-Z0-9]*$") && !Regex.IsMatch(str, @"^\d+$"))
            {


                Console.WriteLine(word.Invoke());
                

            }




            else if (Regex.IsMatch(str, @"^\d+$"))
            {
                Console.WriteLine(num.Invoke());
                

            }

            else if(!Regex.IsMatch(str, @"^[a-zA-Z0-9]+$"))
            {

                Console.WriteLine(junk.Invoke());
                

            }

           




        }
    }
}
