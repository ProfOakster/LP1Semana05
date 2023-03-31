using System;
using System.Text;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string[] inp = new string[args.Length];

                for (int i = 0; i < args.Length; i++)
                    inp[i] = args[i].ToUpper();

                Array.Sort(inp);

                StringBuilder res = new StringBuilder();
                res.AppendJoin("-",inp);
 
                Console.WriteLine(res.ToString());

            }
            else
                Console.WriteLine("NO ARGUMENTS");




            
        }
    }
}
