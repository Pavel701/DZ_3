// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да
   
 Console.Write("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());
    int firstDigit = number / 10000;
    int secondDigit = (number / 1000) % 10;
    int fourthDigit = (number / 10) % 10;
    int fifthDigit = number % 10;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit) {
      Console.WriteLine($"Число {number} является палиндромом");
    } 
else {
      Console.WriteLine($"Число {number} не является палиндромом");
    }



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Таблица кубов чисел:");
    for (int i = 1; i <= n; i++) {
      int cube = i * i * i;
      Console.WriteLine($"{i}   {cube}");
    }
