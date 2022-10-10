/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine("Введите число N больше 1: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
double res = 1;
if (N>0) {
    while (count<=N) {
        res = Math.Pow(count,3);
        Console.Write($"{res}, ");
        count++;
    }
Console.WriteLine();
}
else {  
    Console.WriteLine("Некоректное значение!");
}