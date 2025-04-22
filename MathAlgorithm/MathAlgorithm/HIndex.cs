namespace MathAlgorithm;

public class HIndex
{
    public void FindHIndex()
    {
        Console.Write("Введите количество статей: ");
        int n = int.Parse(Console.ReadLine());

        int[] citat = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите цитирования статьи {i + 1}: ");
            citat[i] = int.Parse(Console.ReadLine());
        }

        // Массив подсчета (максимум n, так как h-index не может быть больше n)
        int[] count = new int[n + 1]; // новый пустой массив, на 1 больше чем n потому что если в массиве есть числа больше длинны самого массимва их некуда будет записывать

        foreach (int c in citat)
        {
            if (c >= n) // если какое-то из чисел массива больше или равно длине самого массива то записываем его в последнюю ячейку массива
            {
                count[n]++;
            }
            else
            {
                count[c]++; // Если нет, то прибавляем в эту ячейку массива по индексу числа. То есть если число 3 то в 3 ячейку +1
            }
        }
        // к примеру массив {3,0,6,1,5} то есть {1,1,0,1,0,2}
        int total = 0;
        for (int i = n; i >= 0; i--) // идем с конца 
        {
            total += count[i]; // берем значение последнего элемента и прибавляем в total после в if сравниваем если значение не подходит повторяем то же действие но total уже не 0 а 2
            if (total >= i)
            {
                Console.WriteLine("h-индекс: " + i);
                return;
            }
        }

        // Если вдруг h-index равен 0
        Console.WriteLine("h-индекс: 0");
    }
}