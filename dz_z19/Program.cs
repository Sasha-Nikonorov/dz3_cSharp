Console.WriteLine("Введите:");
var number = int.Parse(Console.ReadLine()!);

if (number < 0)
number *= (-1);

int a = number / 10000;
int b = (number/1000) - ((number/10000)*10);
int c = (number/100) - ((number/1000)*10);
int d = (number/10) - ((number/100)*10);
int e = number%10;




if (a == e && b ==d)
{
    Console.WriteLine("Да");
}
else if (number >= 100000)
Console.WriteLine("Введи правильное число");
else if (number <= 100000)
Console.WriteLine("Введи правильное число");

else
Console.WriteLine("Нет");
