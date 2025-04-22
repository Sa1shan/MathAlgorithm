using System;
namespace MathAlgorithm;

public class TwoArrow
{
    public void FindNumberTwoArrow()
    {
        Console.Write("Введите длину массива: ");
        int n = int.Parse(Console.ReadLine()); // Длинна массива
        
        int[] array = new int[n]; // сам массив 
        
        for (int i = 0; i < n; i++) // Цикл для проверки, что массив идет по возрастанию
        {
            while (true) // бесконечный цикл тк не знаем кол во элементов в массиве
            {
                Console.Write($"Введите элемент {i}: ");
                int value = int.Parse(Console.ReadLine()); // Числа массива
                
                if (i == 0 || value > array[i - 1]) // проверка того что числа идут по возрастанию
                {
                    array[i] = value; // записываем числа в сам массив 
                    break; // выходим из цикла
                }
                else
                {
                    Console.WriteLine("Ошибка: число должно быть больше предыдущего!");
                }
            }
        }
        
        Console.Write("Введите число k: ");
        int k = int.Parse(Console.ReadLine()); // получаем число К 
        
        int left = 0; // Левая стрелка
        int right = n - 1; // Правая стрелка
        bool found = false; // тэг для завершения
        
        while (left < right) // Цикл пока левая стрелка не сравнялась справой
        {
            int sum = array[left] + array[right]; // переменная для расчеты суммы, число левой стрелки + число правой стрелки

            if (sum == k) 
            {
                Console.WriteLine($"Найдена пара: {array[left]} + {array[right]} = {k}");
                found = true;
                break; // выход из цикла While
            }
            else if (sum < k) 
            {
                left++; // Двигаем левую стрелку вправо
            }
            else
            {
                right--; // Двигаем правую стрелку влево
            }
        }
        
        if (!found)
        {
            Console.WriteLine("Пара с такой суммой не найдена.");
        }
    }
}