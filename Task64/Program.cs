/*Задача 64: Задайте значения N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
*/
Console.Clear();

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    Console.Write($"{num} ");
    if (num == 1) return;
    NaturalNumber(num - 1);
}
NaturalNumber(number);