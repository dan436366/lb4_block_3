using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4_block_3
{
    public partial class Krasilnikov
    {
        public static void DeleteFewRows(ref int[][] array, ref int rows)
        {
            Console.WriteLine("Введіть з якого рядка починаючи знищити елементи:");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть до якого рядка знищити елементи:");
            int k2 = int.Parse(Console.ReadLine());

            k1--;
            k2--;

            int numRows = array.Length;

            if (k1 < 0)
            {
                k1 = 0;
            }
            if (k2 < k1)
            {
                int kadd = k1;
                k1 = k2;
                k2 = kadd;
            }
            if (k2 > numRows)
            {
                k2 = numRows;
            }

            int[][] newJaggedArray = new int[numRows][];

            int count = 0;
            for (int i = 0; i < numRows; i++)
            {
                if (i < k1 || i > k2)
                {
                    newJaggedArray[count] = array[i];
                    count++;
                }
            }

            rows = count;

            Array.Resize(ref newJaggedArray, rows);
            array = newJaggedArray;
            
        }

    }  
}

