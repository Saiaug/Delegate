using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Delegate.ConsoleReader;
using static Delegate.Program;

namespace Delegate
{

   

    public class Program
    {

        public delegate void NewDelegate(string str);
        public static void Main(string[] args)
        {
            string strl;
            
            ConsoleReader reader = new ConsoleReader();
            Iconsolereader d = new Display();
            NewDelegate word = new NewDelegate(d.Onword);
            NewDelegate num = new NewDelegate(d.Onnum);
            NewDelegate junk = new NewDelegate(d.Onjunk);
           

            while (true)
            {
                Console.Write("Input the string : ");
                strl = Console.ReadLine();
                reader.Run(strl, word, num, junk);

               
            }
        }


        

    }

    public interface Iconsolereader
    {
         void Onword(string str);
        void Onjunk(string str);
        void Onnum(string str);
    }

   
 
    public class ConsoleReader
    {

        public  void Run(string str, NewDelegate word, NewDelegate num, NewDelegate junk)
        {
            
            if (Regex.IsMatch(str, "^[a-zA-Z0-9]*$") && !Regex.IsMatch(str, @"^\d+$"))
            {

                word(str);
             

            }

            else if (Regex.IsMatch(str, @"^\d+$"))
            {
                
                num(str);


            }

            else if (!Regex.IsMatch(str, @"^[a-zA-Z0-9]+$"))
            {

                junk(str);


            }



        }

        public class Display : Iconsolereader
        {
            public void Onword(string str)
            {
                
                Console.WriteLine("onword");
            }

            public void Onnum(string str)
            {
                
                Console.WriteLine("onnum");
            }
            public void Onjunk(string str)
            {
                
                Console.WriteLine("onjunk");
            }
        }



    }

}
