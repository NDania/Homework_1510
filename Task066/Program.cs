// Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int Print(int m, int n)
{
    if(n==m)
        return m;
    return Print(m,n-1) + n;
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(m,n));
