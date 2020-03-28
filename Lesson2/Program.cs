using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Choose your style from");
            int[,,] options = new int[3,10,10] //?????????????????????????????????????
            
              {
                {
                    { 0, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 1, 0, 1, 1, 0, 1, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 1, 1, 0, 1, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                },
                {
                    { 0, 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 1, 0, 0, 0, 0, 1, 1, 0, 0 },
                    { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                    { 1, 1, 1, 0, 1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 },
                    { 0, 1, 1, 0, 1, 0, 1, 0, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                },
                {
                    { 0, 1, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 0, 1, 0, 0, 0, 1, 1, 0, 0, 0 },
                    { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 1, 0, 1, 1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 },
                    { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                    { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 }
                }
            };
            for (int i = 0; i < options.GetLength(0); i++)
            {
                int p = i + 1;
                Console.WriteLine($"\n Method number:{p}");// why we use @?
                for (int x = 0; x < options.GetLength(1); x++)
                {
                    //Console.WriteLine();
                    for (int c = 0; c < options.GetLength(2); c++)
                    {
                        Console.Write($"{options[i, x, c]}");
                        if (c == options.GetLength(2)-1)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(",");
                        }
                    }
                }
            }
            Console.WriteLine("Choose style by entering number of favorite");
            int style = int.Parse(Console.ReadLine()) -1;
            int[,] myStyle = new int[ 10, 10];            
            //int[,] RanStyle = new int[ 10, 10];            
            
                for (int vx = 0; vx < options.GetLength(1); vx++)
                {
                    for (int bx = 0; bx < options.GetLength(2); bx++)
                    {
                        myStyle[vx, bx] = options[style, vx, bx];
                    }
                }
            Console.WriteLine("my style:");
            ShowArray(myStyle);
            Random r = new Random();
            int rr = r.Next(1,3);
            Console.WriteLine($"\nA.I. chose");
            rr -= 1;
            int R1 = r.Next(10);
            int R2 = r.Next(10);
            int[,] EnemyStyle = new int[10, 10];
            for (int i = 0; i < options.GetLength(0); i++)
            {
                for (int v = 0; v < options.GetLength(1); v++)
                {
                    for (int b = 0; b < options.GetLength(2); b++)
                    {
                        EnemyStyle[v, b] = options[rr, v, b];
                    }
                }
            }
            Console.WriteLine("Enemy:");
            ShowArray(EnemyStyle);
            Console.WriteLine("Press \"Enter\" if you ready");
            Console.ReadLine();
            while (true)//myStyle or EnemyStyle not more than 0
            {
                if (CheckArray(myStyle) == true)
                {
                    Console.WriteLine("Type coordinates that you want to shoot. Row and column (by one for each line)");
                    int C1 = int.Parse(Console.ReadLine()) -1;
                    int C2 = int.Parse(Console.ReadLine()) -1;
                    if (EnemyStyle[C1, C2] != -1)
                    {
                        Console.WriteLine(EnemyStyle[C1, C2]);
                        Console.WriteLine("!!");
                        if (0 < EnemyStyle[C1, C2])
                        {
                            EnemyStyle[C1, C2] = -1;
                        }
                        else if (0 == EnemyStyle[C1, C2])
                        {
                            EnemyStyle[C1, C2] = -2;
                        }
                    }
                    Console.WriteLine("My style:");
                    ShowArray(myStyle);
                    //Console.WriteLine("TEST");
                    //ShowArray(EnemyStyle);
                }
                else
                {
                    Console.WriteLine($"Congrats! Victory of {name} against machine");
                    break;
                }
                if (CheckArray(myStyle) == true)
                {
                    if (myStyle[R1, R2] != -1)
                    {
                        if (0 < myStyle[R1, R2])
                        {
                            myStyle[R1, R2] = -1;
                        }
                        else if (0 == myStyle[R1, R2])
                        {
                            myStyle[R1, R2] = -2;
                        }
                    }
                    Console.WriteLine("Enemy");
                    ShowArray(EnemyStyle);
                }
                else
                {
                    Console.WriteLine($"Duh..You lost.Good luck next time.  ");
                    break;
                }
            }
        }
        static void ShowArray(int[,] array, string separator = ",")
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write($"{array[i, k]}{separator}");
                    //array[i, k]++;
                }
                Console.WriteLine();
            }
        }
        static bool CheckArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[i, k] == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
