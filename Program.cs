//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵), 2, 4 -> 16
/*Console.Write("Введите число А: ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число В: ");
int Num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число A в натуральной степени B равно: {GetDegree(Num1)}");
//Метод --------------------------------------------------------
int GetDegree(int Num1)
{
    int Degree = Num1;
    for (int i = 1; i < Num2; i++)
    {
        Degree = Degree * Num1;
    }
    return Degree;
}*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
//цифр в числе. 452-> 11, 82-> 10, 9012-> 12
/*Console.Write("Введите число: ");
string Numb = Console.ReadLine()!;
Console.WriteLine($"Сумма цифр в числе: {GetSum(Numb)}");
//Метод --------------------------------------------------------
int GetSum(string N)
{
    int size = Numb.Length;
    int sum = Convert.ToInt32(Numb[0]);
    int FerstNumb = Convert.ToInt32(Numb[0]);
    for (int i = 1; i <= size; i++)
    {
        sum = FerstNumb + Numb[i];
    }
  return sum;
}*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран. (числа берете любые)
int[] Array = GetArray(8);
Console.WriteLine($"{String.Join("; ", Array)}");
//Метод--------------------------------------------------------
int[] GetArray(int size)
{
 int[] Array = new int[size];
for (int i = 0; i < size; i++)
{
    Array[i] = new Random().Next();
}
return Array;
}
