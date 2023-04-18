// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да
   
 Console.Write("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());
    int first = number / 10000;
    int second = (number / 1000) % 10;
    int fourth = (number / 10) % 10;
    int fifth = number % 10;
    if (first == fifth && second == fourth) {
      Console.WriteLine($"Число {number} является палиндромом");
    } 
else {
      Console.WriteLine($"Число {number} не является палиндромом");
    }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53

    Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
    double x1 = double.Parse(Console.ReadLine());
    double y1 = double.Parse(Console.ReadLine());
    double z1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
    double x2 = double.Parse(Console.ReadLine());
    double y2 = double.Parse(Console.ReadLine());
    double z2 = double.Parse(Console.ReadLine());
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {distance}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Таблица кубов чисел:");
    for (int i = 1; i <= n; i++) {
      int cube = i * i * i;
      Console.WriteLine($"{i}   {cube}");
    }
