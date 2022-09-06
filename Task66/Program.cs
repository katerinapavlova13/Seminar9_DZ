/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.Write("Введите положительное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма чисел от {numM} до {numN} ->  ");

int SumNumber(int numM, int numN)
{
    if (numN == numM) return numM;
    return numN + SumNumber(numM, numN - 1);
}
//int sum = 0;
//if (numM == numN) return 0;
//if (numM < numN)
//{
//    sum = (numN * (numN + 1)) / 2 - ((numM - 1) * ((numM - 1) + 1)) / 2;
//    Console.Write($"{sum}");
//}
//return sum;
Console.Write(SumNumber(numM, numN));
SumNumber(numM, numN);






