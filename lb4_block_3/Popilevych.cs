using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4_block_3
{
    public partial class Popilevych
    {
        public static void DeleteRowsByRange(ref int[][] jaggedArray, ref int rows)
        {
            Console.WriteLine("Введіть з якого рядка починаючи знищити елементи:");
            int k1 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введіть до якого рядка знищити елементи:");
            int k2 = int.Parse(Console.ReadLine()) - 1;
            int numRows = jaggedArray.Length;
            if (k1 < 0 || k2 < k1 || k2 > numRows)
            {
                Console.WriteLine("Видалити неможливо індекс поза доступними межами");

            }
            else
            {
                int[][] newJaggedArray = new int[numRows][];
                int count = 0;
                for (int i = 0; i < numRows; i++)
                {
                    if (i < k1 || i > k2)
                    {
                        newJaggedArray[count] = jaggedArray[i];
                        count++;
                    }
                }
                Array.Resize(ref newJaggedArray, count);
                jaggedArray = newJaggedArray;
                rows = count;


            }
        }

    }  
}

