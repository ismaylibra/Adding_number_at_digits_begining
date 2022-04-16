using System;

namespace Homework_1_18._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Add(a);
        }  public static void Add(int num )
        {
            int a = num;
            int count = 0;
            Console.Write("Elave olunacaq eded: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                num /= 10;
                count++;
            }
            
            Console.Write("Yeni eded: ");
            Console.Write(num2 * (Math.Pow(10, count++)) + a);
        }
    } 
        

    }

