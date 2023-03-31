using System;
using System.Text;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if arguments were given
            if (args.Length > 0)
            {
                //Declares new string array
                string[] inp = new string[args.Length];

                //Turns all arguments to uppercase and stores them in inp
                for (int i = 0; i < args.Length; i++)
                    inp[i] = args[i].ToUpper();

                //Sorts strings in array by alphabetical order
                Array.Sort(inp);

                //Unites all strings in res in a StringBuilder, connected by "-"'s
                StringBuilder res = new StringBuilder();
                res.AppendJoin("-",inp);

                //Displays result
                Console.WriteLine(res.ToString());

            }
            //If no arguments are given
            else
                Console.WriteLine("NO ARGUMENTS");




            
        }
    }
}
