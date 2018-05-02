using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Sentence");
            String StringToReverse = Console.ReadLine();
            if (StringToReverse != "")
            {
                try
                {
                    String ReversedString = String.Join(" ", StringToReverse.Split(' ')
            .Select(x => new String(x.Reverse().ToArray()).ToLower()));
                    Console.WriteLine("Reversed is:");
                    Console.WriteLine(ReversedString);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }

            }else {

                Console.WriteLine("Please Enter a sentence");
                Console.ReadLine();
            }
        }

    }
}
