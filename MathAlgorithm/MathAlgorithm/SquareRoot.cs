namespace MathAlgorithm;

public class SquareRoot
{
    public void FindSquareRoot()
    {
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out double number) && number >= 0) // Получаем число от пользователя присваиваем в переменную number и проверяем что оно не отрицательное
        {
            double root = CalculateSquareRoot(number, 10); // Метод как Sqrt для рассчета корня, сохряняем в переменную root

            // Проверим, целое ли число, метод снизу округляет вниз = 4.9 = 4
            if (Math.Abs(root - Math.Round(root)) < 1e-10) 
            {
                Console.WriteLine($"Квадратный корень из {number} = {Math.Round(root)}");
            }
            else
            {
                Console.Write("Корень нецелый. Сколько знаков после запятой хотите вывести? ");
                if (int.TryParse(Console.ReadLine(), out int decimalPlaces) && decimalPlaces >= 0) // Получаем кол-во знаков и присваивем в переменную
                {
                    string format = "F" + decimalPlaces; // F указывает на кол-во знаков после запятой если decimalPlaces = 4 то строка format станет "F4" и так далее
                    Console.WriteLine($"Квадратный корень из {number} ≈ {root.ToString(format)}");
                }
                else
                {
                    Console.WriteLine("Некорректное количество знаков после запятой.");
                }
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное неотрицательное число.");
        }
    }

    // В тг посмотерть ссылку на GTP 
    static double CalculateSquareRoot(double number, int precision)
    {
        double low = 0;
        double high = number >= 1 ? number : 1;
        double mid;
        double eps = Math.Pow(10, -precision - 1);
        while (high - low > eps)
        {
            mid = (low + high) / 2;
            double square = mid * mid;

            if (square > number)
            {
                high = mid;
            }
            else
            {
                low = mid;
            }
        }

        return (low + high) / 2;
    }
}