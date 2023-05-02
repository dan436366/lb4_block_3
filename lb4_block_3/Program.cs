using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4_block_3
{
    internal class Program
    {
	static void PrintArray(int rows, int col, int[][] array)
        {
            if (rows == 0)
            {
                Console.WriteLine("Масив порожній!");
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
	public static void ChooseTheWayToFill(int rows, int col, ref int[][] array)
        {
            Console.Write("Введіть 1, щоб заповнити масив рандомно, або 2, щоб заповнити його вручну: ");
            int choiceOfInput = Convert.ToInt32(Console.ReadLine());
            switch (choiceOfInput)
            {
                case 1:
                    RandomFill(rows, col, ref array);
                    Console.WriteLine("Початковий масив: ");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write(array[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Введіть масив: ");
                    ByHandFill(rows, col, ref array);
                    break;
            }
        }
        public static void Block_2()
        {
            Console.WriteLine("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
            string choiceOfStudent = Console.ReadLine().ToLower();
            Console.Write("Введіть к-сть рядків та стовпчиків в масиві: ");
            string[] size = Console.ReadLine().Trim().Split();
            int rows = Convert.ToInt32(size[0]);
            int col = Convert.ToInt32(size[1]);
            int[][] array = new int[rows][];
            ChooseTheWayToFill(rows, col, ref array);
            do
            {
                switch (choiceOfStudent)
                {
                    case "krasilnikov":
                        Krasilnikov.MethodKrasil(ref rows, col, ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(rows, col, array);
                        break;
                    case "zaichuk":
                        Zaichuk.MethodZaichuk(ref array, col, ref rows);
                        Console.WriteLine("Результат:");
                        PrintArray(rows, col, array);
                        break;
                    case "popilevych":
                        Popilevych.MethodPopil(ref rows, col, ref array);
                        Console.WriteLine("Результат:");
                        PrintArray(rows, col, array);
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
                Console.WriteLine("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
                choiceOfStudent = Console.ReadLine().ToLower();
                if (choiceOfStudent == "krasilnikov" || choiceOfStudent == "zaichuk" || choiceOfStudent == "popilevych")
                {
                    Console.WriteLine("Бажаєте створити новий масив?(Так/Ні)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.Write("Введіть к-сть рядків та стовпчиків в масиві: ");
                        size = Console.ReadLine().Trim().Split();
                        rows = Convert.ToInt32(size[0]);
                        col = Convert.ToInt32(size[1]);
                        array = new int[rows][];
                        ChooseTheWayToFill(rows, col, ref array);
                    }
                }
            } while (choiceOfStudent != "0");
        }
        static void Main(string[] args)
        {
           Block_2();
        }
    }
}
