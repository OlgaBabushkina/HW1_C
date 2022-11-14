/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int maxnumber;
int minNumber;
if (numberA > numberB)
{
    maxnumber = numberA;
    minNumber = numberB;
    Console.WriteLine("Наибольшее число = " + numberA + ", наименьшее число = " + minNumber);
}
else if (numberB > numberA)
{
    maxnumber = numberB;
    minNumber = numberA;
    Console.WriteLine("Наибольшее число = " + numberB + ", наименьшее число = " + minNumber);
}
else Console.WriteLine("Числа равны");

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int maxnumber = numberA;
if (numberB > numberA)
{
    maxnumber = numberB;
}
if (numberC > maxnumber)
{
    maxnumber = numberC;
}
Console.WriteLine("Максимальное число = " + maxnumber);

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
if ((numberA%2)==0)
{
    Console.WriteLine("Число: " + numberA + " - четное");
}
else Console.WriteLine("Число: " + numberA + " - нечетное");

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int number = 2;
if (N <= 1)
{
Console.WriteLine("Число должно быть больше единицы");
}
while (N >= number)
{
Console.Write(number + " ");
number = number + 2;
}
