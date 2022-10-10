/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число: ");
String number = Console.ReadLine()!;
if ((number.Length == 5)) {
    int n1 = Convert.ToInt32(number[0]);
    int n2 = Convert.ToInt32(number[1]);
    int n4 = Convert.ToInt32(number[3]);
    int n5 = Convert.ToInt32(number[4]);
    if (n1 == n5 && n2 == n4) {
        Console.WriteLine($"Введенное число {number} является палиндромом.");
    } else
    Console.WriteLine($"Введенное число {number} не является палиндромом.");
} else
Console.WriteLine("Число не является пятизначным!");