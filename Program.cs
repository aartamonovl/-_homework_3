//Задача 19: Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

// void Message(string msg)
// {
//     Console.WriteLine(msg);
// }

// void Palindrom(int number)
// {
//     if(number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10) Message("Yes");
//     else Message("No");
// }

// Console.Write("Input the fifth-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num / 10000 > 0 && num / 10000 < 9) Palindrom(num);
// else Message("Please, input fifth-digit number. ");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// double DistanceBetween3DPoints (int xa, int ya, int za, int xb, int yb, int zb){
//     double ab = Math.Sqrt(((xb-xa)*(xb-xa)) + ((yb-ya)*(yb-ya)) + ((zb - za)*(zb - za)));
//     return Math.Round(ab,2);
// }

// Console.Write("Введите xa: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ya: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите za: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите xb: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите yb: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите zb: ");
// int zb = Convert.ToInt32(Console.ReadLine());
// double res = DistanceBetween3DPoints(xa, ya, za, xb, yb, zb);
// Console.WriteLine($"Расстояние между точками ({xa},{ya},{za}) и ({xb},{yb},{zb}) равно {res}");

//Задача 23: Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

// void TableOfThirdDegree (int n)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         Console.Write($"{i * i * i} ");
//     }
// }

// Console.Write("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x > 0) TableOfThirdDegree(x);
// else Console.WriteLine("Значение должны быть больше 0");
// Console.WriteLine();