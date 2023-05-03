using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4_block_3
{
    internal class Zaichuk
    {
        public static void Delete(ref int[][] array, int col, ref int rows)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожній, створіть новий массив");
            }
            else
            {
                Console.WriteLine("Введіть номер рядка, який бажаєте видалити:");
                int k=0;
                do
                {
                    k = int.Parse(Console.ReadLine());
                    if (k > array.Length||k<0)
                    {
                        Console.WriteLine("Такого рядка не існує, введіть ще раз, або натисніть 0 для виходу с задачі");
                    }
                    else
                    {
                        int[][] new_array = new int[array.Length-1][];
                        for (int i = 0; i < k - 1; i++)
                        {
                            new_array[i] = array[i];
                        }
                        for (int i = k - 1; i < rows - 1; i++)
                        {
                            new_array[i] = array[i + 1];
                        }
                        array = new_array;
                        rows -= 1;
                        break;
                    }
                } while (k != 0);
            }
        }
    }
}
