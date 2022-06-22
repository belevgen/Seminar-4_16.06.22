// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
string istring = Console.ReadLine();
int inum = int.Parse(istring);
int lenght = istring.Lenght;
int[] arr = new int[lenght];
int index = 0;
int sum = 0;
for (index = 0; index < lenght; index++)
{   
    var tmp = inum % 10;
    inum = inum / 10;
    sum = sum + tmp;
}
Console.Write($"Сумма цифр числа {istring} равна {sum}");
