﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peymayesh_sotoni_Csharp
{
    class takalif
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10,10];
            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int number, temp = 0;
            number = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    if (number == arr[j, i])
                        temp++;
                }
            }
            Console.WriteLine(temp);
        }
    }
}
