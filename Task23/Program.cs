/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for(int index = 1; index <= n; index++) //Начальное число = 1; до тех пор, пока оно меньше или равно введенному числу; прибавляем шаг
{
    double result = Math.Pow(index, 3);
    Console.Write($"{result}; ");
}
