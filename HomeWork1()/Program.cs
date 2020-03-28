using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press \"Enter\" to start the game");
            Console.ReadLine();
            Console.WriteLine("First thing first, You need a nickname. Just type it below ");
            string name1 = Console.ReadLine();
            Console.WriteLine("The second thing second, You must have a name of the opponent. Just type it below");
            string name2 = Console.ReadLine();
            Random r = new Random();            
            int i = r.Next(100);
            int o = r.Next(100);
            int p = r.Next(100);
            int x = r.Next(100);            
            Console.WriteLine($"Player {name1} got: {i} and {o}");
            Console.WriteLine($"Player {name2} got: {p} and {x}");
            int sum1 = i + o;
            int sum2 = p + x;
            //Console.WriteLine(i);
            if (sum1 > sum2)
            {
                Console.WriteLine($"Winner is {name1}");
            }
            else if (sum2 > sum1)
            {
                Console.WriteLine($"Winner is {name2}");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
