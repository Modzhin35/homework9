// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Input(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SearchSumma(int min, int max)
{
    if (min > max) return 0;
    else return min + SearchSumma(min + 1, max);
}

int firstNum = Input("Введите минимальное число: ");
int secondNum = Input("Введите максимальное число: ");
if (firstNum >= secondNum) Console.WriteLine("Минимальное число должно быть меньше максимального.");
else
{
    Console.WriteLine($"Сумма элементов от {firstNum} до {secondNum} = {SearchSumma(firstNum, secondNum)}");
}
