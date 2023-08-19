// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
// ввел пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//   Console.WriteLine("Введите числа через запятую:");
//         string input = Console.ReadLine();
        
//         // Разделяем числа запятой
//         string[] numbers = input.Split(',');
        
//         int count = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             int num = int.Parse(numbers[i]);
            
//             if (num > 0)
//                 count++;
//         }
        
//         Console.WriteLine($"Количество чисел больше 0: {count}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//   Console.WriteLine("Введите значения b1, k1, b2 и k2, разделенные пробелами:");
//         string input = Console.ReadLine();
        
//         string[] values = input.Split(' ');
    
//         int b1 = int.Parse(values[0]);
//         int k1 = int.Parse(values[1]);
//         int b2 = int.Parse(values[2]);
//         int k2 = int.Parse(values[3]);
        
//         // Значение х находится как разность значений b2 и b1, деленную на разность значений k1 и k2
//         float x = (float)(b2 - b1) / (k1 - k2);
//         float y = k1 * x + b1;
        
//         Console.WriteLine($"Точка пересечения: ({x}; {y})");
    
