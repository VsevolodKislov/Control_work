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
    if (array.Length == 0)
     {
         Console.WriteLine("[]");
         return;
     }

     Console.Write("[");
     for (int i = 0; i < (array.Length - 1); i++)
     {
         Console.Write($"{array[i]}, ");
     }
    Console.Write($"{array[array.Length-1]}]"); }

int CountElementsUnder3Chars (string[] array)
 {   
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i].Length <= 3) count++;
     }
     return count;
 }
 string[] DuplicateArray(string[] array, int length)
 {
     string[] newArray = new string[length];
     int index = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i].Length <= 3) 
         {
             newArray[index] = array[i];
             index++;
         }
     }
     return newArray;
 }

 Console.WriteLine("Создание массива, введите длину массива: ");
 int userLength = 0;
 while (!int.TryParse(Console.ReadLine(), out userLength) || userLength < 1)
 {
     Console.WriteLine("Неверный ввод. Введите число больше 0: ");
 }

 string[] userArray = CreateArray(userLength);
 PrintArray(userArray);
 int arrayCount = CountElementsUnder3Chars(userArray);
 string[] duplicatedArray = DuplicateArray(userArray, arrayCount);
 Console.Write(" -> ");
 PrintArray(duplicatedArray);