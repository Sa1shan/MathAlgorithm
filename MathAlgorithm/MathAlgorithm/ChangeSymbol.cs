namespace MathAlgorithm;

public class ChangeSymbol
{
    public void SymbolChenging()
    {
        Console.Write("Введите количество строк (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[m, n];
        Random rand = new Random();

        Console.WriteLine("\nСгенерированная матрица:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(-10, 11); // Числа от -10 до 10 включительно
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sum = 0;
        int negativeCount = 0;
        int minAbs = int.MaxValue;
        int minAbsValue = 0;

        // Подсчёт всех чисел, определение минимального по модулю
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int val = matrix[i, j];
                sum += Math.Abs(val); // Принимаем все числа как положительные
                if (val < 0)
                {
                    negativeCount++;
                }
                if (Math.Abs(val) < minAbs)
                {
                    minAbs = Math.Abs(val);
                    minAbsValue = val;
                }
            }
        }

        // Если отрицательных чисел нечётное количество, меняем знак для самого маленького по модулю
        if (negativeCount % 2 != 0)
        {
            sum -= 2 * Math.Abs(minAbsValue); // Отнимаем дважды минимальное по модулю число
        }

        Console.WriteLine($"\nМаксимальная возможная сумма после изменения знаков: {sum}");
    }
}