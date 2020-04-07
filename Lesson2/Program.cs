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
            int[,] firstStyle = new int[10, 10];
            int[,] secondStyle = new int[10, 10];
            int[,] secondZero = new int[10, 10];
            
            int[,] firstZero = new int[10, 10];
            
            {
                //for (int i = 0; i < options.GetLength(0); i++)
                //{
                //    for (int v = 0; v < options.GetLength(1); v++)
                //    {
                //        for (int b = 0; b < options.GetLength(2); b++)
                //        {
                //            EnemyStyle[v, b] = options[rr, v, b];
                //        }
                //    }
                //}
            }

            Console.WriteLine("Enter first player Name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter second player Name");
            string name2 = Console.ReadLine();
            
            Console.WriteLine("Choose your style from");
            int[,,] options = new int[3, 10, 10] //?????????????????????????????????????
            
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
                        if (c == options.GetLength(2) - 1)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("|");
                        }
                    }
                }
            }
            Console.WriteLine($"{name1}, choose style by entering number of favorite");
            int style = int.Parse(Console.ReadLine()) - 1;
            //int[,] RanStyle = new int[ 10, 10];            

            for (int vx = 0; vx < options.GetLength(1); vx++)
            {
                for (int bx = 0; bx < options.GetLength(2); bx++)
                {
                    firstStyle[vx, bx] = options[style, vx, bx];
                }
            }
            Console.WriteLine("my style:");
            ShowArray(firstStyle);
            {
                //Random r = new Random();
                //int rr = r.Next(1, 3);
                //rr -= 1;
                //int R1 = r.Next(10);
                //int R2 = r.Next(10);
            }
            Console.ReadLine();
            Console.Clear();
            /////////////////////////////////////////////////////
            Console.WriteLine("Choose your style from");
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
                        if (c == options.GetLength(2) - 1)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("|");
                        }
                    }
                }
            }
            Console.WriteLine($"{name2}, choose style by entering number of favorite");
            int style1 = int.Parse(Console.ReadLine()) - 1;

            for (int vxx = 0; vxx < options.GetLength(1); vxx++)
            {
                for (int bxx = 0; bxx < options.GetLength(2); bxx++)
                {
                    secondStyle[vxx, bxx] = options[style1, vxx, bxx];
                }
            }
            Console.WriteLine("my style:");
            ShowArray(secondStyle);
            Console.ReadLine();
            Console.Clear();
            /////////////////////////////////

            Console.WriteLine("Press \"Enter\" if you ready");
            Console.ReadLine();
            Console.Clear();

            SetZeroArray(secondZero);
            SetZeroArray(firstZero);
            while (true)//myStyle or EnemyStyle not more than 0
            {
                if (CheckArray(firstStyle))
                {
                    ShowArray(secondZero);
                    Console.WriteLine($"{name1}' move\nType coordinates that you want to shoot. Row and column (by one for each line)");
                    int c1 = int.Parse(Console.ReadLine()) - 1;
                    int c2 = int.Parse(Console.ReadLine()) - 1;
                    do
                    {
                    ShootArray(secondStyle, c1, c2);
                     ShootZeroArray(secondStyle, secondZero, c1, c2);
                        Console.Clear();
                        Console.WriteLine("Shoot one more time, coz you hit");
                        ShowArray(secondZero);
                    }
                    while (secondStyle[c1,c2] == -1);
                    {
                        //if (EnemyStyle[c1 , c2] != -1)
                        //{
                        //    Console.WriteLine(EnemyStyle[c1, c2]);
                        //    Console.WriteLine("!!");
                        //    if (0 < EnemyStyle[c1, c2])
                        //    {
                        //        EnemyStyle[c1, c2] = -1;
                        //    }
                        //    else if (0 == EnemyStyle[c1, c2])
                        //    {
                        //        EnemyStyle[c1, c2] = -2;
                        //    }
                        //}
                        //Console.WriteLine("My style:");
                        //ShowArray(myStyle);
                        //Console.WriteLine("TEST");
                        //ShowArray(EnemyStyle);
                    }
                    Console.WriteLine("You missed. Click \"Enter\" to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Congrats! Victory of {name1} against machine");
                    break;
                }
                if (CheckArray(firstStyle) == true)
                {

                    ShowArray(firstZero);
                    Console.WriteLine($"{name2}' move\nType coordinates that you want to shoot. Row and column (by one for each line)");
                    int c1 = int.Parse(Console.ReadLine()) - 1;
                    int c2 = int.Parse(Console.ReadLine()) - 1;
                    do
                    {
                        ShootArray(firstStyle, c1, c2);
                        ShootZeroArray(firstStyle, firstZero, c1, c2);
                        Console.Clear();
                        Console.WriteLine("Shoot one more time, coz you hit");
                        ShowArray(firstZero);
                    }
                    while (secondStyle[c1, c2] == -1);
                    Console.WriteLine("You missed. Click \"Enter\" to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Duh..You lost.Good luck next time.  ");
                    break;
                }
            }
        }
        static void ShowArray(int[,] array, string separator = "|")
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
        static void SetZeroArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)//row
            {
                for (int k = 0; k < array.GetLength(1); k++)//column
                {
                    
                    {
                        array[i, k] = 0;
                    }
                }
            }
        }
        
        static void ShootArray(int[,] array, int r, int c)
        {
            if (array[r, c] != -1)
            {
                //Console.WriteLine(array[r, c]);
                //Console.WriteLine("!!");
                if (0 < array[r, c])
                {
                    array[r, c] = -1;
                }
                else if (0 == array[r, c])
                {
                    array[r, c] = -2;
                }
            }
           // array[r, c] -= 1;
        }
        static void ShootZeroArray(int[,] orig, int[,] array,int r,int c)
        {

            //Console.WriteLine(array[r, c]);
            //Console.WriteLine("!!");
            ShootArray(orig, r, c);
            if (orig[r, c] == -1)
            {
                if (0 == array[r, c])
                {
                    array[r, c] = -1;
                }
            }
            if (orig[r, c] == -2)
            { 
                if (0 == array[r, c])
                {
                    array[r, c] = -2;

                }
            }
        }
    }
}
