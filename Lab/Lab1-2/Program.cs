using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] input()
        {
            int x;
            Console.WriteLine("Input many number : ");

            x = Convert.ToInt32(Console.ReadLine());
            int[] y = new int[x];


            for (int i = 0; i < x; i++)
            {
               
                Console.WriteLine("Number" + i+1);
                int k = Convert.ToInt32(Console.ReadLine());
                y[i] = k;
            }

            return y;
        }

        static int[] process(int[] input)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }


            return input;
        }

        static void output(int[] number)
        {
            foreach (int a in number)
            {
                Console.Write(a);
                Console.Write(" ");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            output(process(input()));
        }
    }
}

