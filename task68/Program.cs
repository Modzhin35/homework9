// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
uint Input(string message)
{
    Console.Write(message);
    return Convert.ToUInt32(Console.ReadLine());
}

uint Accerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Accerman(m - 1, 1);
    else
        return Accerman(m - 1, Accerman(m, n - 1));
}

uint firstNum = Input("Введите минимальное число: ");
uint secondNum = Input("Введите максимальное число: ");
Console.Write(Accerman(firstNum, secondNum));