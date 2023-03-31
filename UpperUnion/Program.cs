using System;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string[] res = new string[args.Length];

                for (int i = 0; i < args.Length; i++)
                    res[i] = args[i].ToUpper();







                for (int i = 0; i < res.Length; i++)
                    Console.WriteLine(res[i]);
            }
            else
                Console.WriteLine("NO ARGUMENTS");




            
        }
    }
}
