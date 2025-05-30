using System.Diagnostics;

namespace MathAlgorithm;

public class FindNumber
{
    public void FindNumberInTable()
    {
        Console.Write("Введите количество строк (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] table = new int[m, n]; // Массив из двух элементов то есть матрица 
        int value = 1;

        // Заполняем таблицу числами по порядку (i - строка, j - столбец)
        for (int i = 0; i < m; i++) // пока i < m потому что массив начинается с 0 элемента 
        {
            for (int j = 0; j < n; j++)
            {
                table[i, j] = value++; // i и j это строки и столбцы то есть если строка i и столбец j были 0, то произошло value ++ и стало 1
            }
        }

        // Вывод таблицы
        Console.WriteLine("\nСформированная таблица:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{table[i, j],4}"); // 4 что бы было выравнивание
            }
            Console.WriteLine();
        }

        // Ввод числа k
        Console.Write("\nВведите число для поиска (k): ");
        int k = int.Parse(Console.ReadLine());

        // Поиск за O(m + n)
        int row = 0; // строка
        int col = n - 1; // столбец 
        bool found = false;

        while (row < m && col >= 0) // пока row меньше m то есть мы в предлах матрицы и col тоже 
        {
            if (table[row, col] == k) // если число в позиции (0, n - 1) равно К то выводим
            {
                found = true;
                Console.WriteLine($"Число {k} найдено на позиции ({row + 1}, {col + 1})");
                break;
            }
            else if (table[row, col] > k) // если число в позиции (0, n - 1) больше то двигаем столбец влево 
            {
                col--; // Двигаемся влево
            }
            else // если число в позиции (0, n - 1) меньше то двигаем строку вниз 
            {
                row++; // Двигаемся вниз
            }
        }

        if (!found)
        {
            Console.WriteLine($"Число {k} не найдено в таблице.");
        }
    }
}