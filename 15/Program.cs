// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int numberA = Convert.ToInt32(input);
if(numberA == 1)
{
    Console.WriteLine("Понедельник");
    Console.WriteLine("День не является выходным");
}
else if (numberA == 2)
{
Console.WriteLine("Вторник");
Console.WriteLine("День не является выходным");
}
else if (numberA == 3)
{
Console.WriteLine("Среда");
Console.WriteLine("День не является выходным");
}
else if (numberA == 4)
{
Console.WriteLine("Четверг");
Console.WriteLine("День не является выходным");
}
else if (numberA == 5)
{
Console.WriteLine("Пятница");
Console.WriteLine("День не является выходным");
}
else if (numberA == 6)
{
Console.WriteLine("Суббота");
Console.WriteLine("День является выходным");
}
else if (numberA == 7)
{
Console.WriteLine("Воскресенье");
Console.WriteLine("День является выходным");
}
else
{
Console.WriteLine("Нет такого дня недели");
}
