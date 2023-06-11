// Задача 34
// class Program
// {
//     static void Main(string[] args)
//     {
        
//         int[] numbers = new int[4];
//         Random random = new Random();
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000);
//             Console.Write(numbers[i] + " ");
//         }

//         Console.WriteLine();

    
//         int evenCount = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

        
//         Console.WriteLine("Количество чётных чисел в массиве: " + evenCount);
//     }
// }


// Задача 36
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = new int[4];
//         Random random = new Random();
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(-10, 10);
//             Console.Write(numbers[i] + " ");
//         }

//         Console.WriteLine();


//         int sum = 0;
//         for (int i = 1; i < numbers.Length; i+=2)
//         {
//             sum += numbers[i];
//         }

         
//         Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);
//     }
// }

// Задача 38
// class Program
// {
//     static void Main(string[] args)
//     {
       
//         double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };
//         Console.Write("Массив: ");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }

//         Console.WriteLine();

        
//         double max = numbers[0];
//         double min = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//             {
//                 max = numbers[i];
//             }

//             if (numbers[i] < min)
//             {
//                 min = numbers[i];
//             }
//         }

    
//         double diff = max - min;

        
//         Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + diff);
//     }
// }

// Задача 35

// class Program
// {
//     static void Main()
//     {
//         int[] arr = new int[123]; // Создаем массив из 123 элементов
//         int count = 0; // Количество элементов, удовлетворяющих условию

//         // Заполняем массив случайными числами
//         Random rand = new Random();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = rand.Next(1, 200); // Числа могут быть любыми от 1 до 199 включительно
//         }

//         // Ищем элементы, удовлетворяющие условию
//         foreach (int num in arr)
//         {
//             if (num >= 10 && num <= 99)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество элементов, значения которых лежат в отрезке [10, 99]: {count}");
//     }
// }