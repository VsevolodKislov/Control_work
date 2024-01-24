




string[] CreateArray(int length)
 {   
     string[] array = new string[length];
     for (int i = 0; i < length; i++)
     {
         Console.WriteLine($"Введите {i+1} элемент массива");
         array[i] = Console.ReadLine()!;
     }
     return array;
 }

 void PrintArray (string[] array)
 {   
     Console.Write("Массив: [ ");
     for (int i = 0; i < (array.Length - 1); i++)
     {
         Console.Write($"{array[i]}, ");
     }
     Console.Write($"{array[array.Length-1]}]");
 }
 
 Console.WriteLine("Создание массива, введите длину массива: ");
 int userLength = int.Parse(Console.ReadLine()!);
 string[] userArray = CreateArray(userLength);
 PrintArray(userArray);