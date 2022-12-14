// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int Print(int m, int n)
{
    if(m==0)
        return n+1;
    if(n==0)    
        return Print(m-1,1);
    else
        return Print(m-1, Print(m, n-1));
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(m,n));