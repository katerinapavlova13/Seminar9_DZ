/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

Console.Clear();

Console.Write("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int FuncAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
        return FuncAckerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return FuncAckerman(m - 1, FuncAckerman(m, n - 1));
    return m;
}

int res = FuncAckerman(m, n);
Console.Write($"{res}");


