using System.Drawing;

namespace MathAlgorithm;

public class RobingHouses
{
    public void FindRobingHouses()
    {
        // Вводим длину массива
        Console.Write("Введите количество домов (n):");
        int n = int.Parse(Console.ReadLine());

        // Проверяем, если количество домов равно 0
        if (n == 0)
        {
            Console.WriteLine("Максимальный выигрыш: 0 ");
            return;
        }

        // Вводим массив чисел, представляющий количество долларов в каждом доме
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите количество долларов в доме {i + 1}:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Для маленьких массивов сразу выводим результат
        if (n == 1)
        {
            Console.WriteLine("Максимальный выигрыш: " + arr[0]);
            return;
        }

        // Инициализация К примеру массив 10,20,30,40,50
        int prev2 = arr[0]; // = 10
        int prev1 = Math.Max(arr[0], arr[1]); // (10, 20) Большее из этих двух  = 20

        // Пройдем по массиву с 2-го дома
        for (int i = 2; i < n; i++) // начинаем со втрого то есть с третьего т.к. первые два уже взяли выше 
        {
            int current = Math.Max(prev1, prev2 + arr[i]); // Больее их этих двух (20, 10 + 30) = 40
            prev2 = prev1; // Был 10 стал теперь 20
            prev1 = current; // Был 20 теперь стал 40 
            // Потом делаем тоже самое с новыми значениями и так пока не закончаться элементы в массиве
        }

        // Ответ в prev1
        Console.WriteLine("Максимальный выигрыш: " + prev1);
    }
}