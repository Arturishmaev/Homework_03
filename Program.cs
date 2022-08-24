/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

System.Console.WriteLine("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
string polindrom = Convert.ToString(number);

if (polindrom[0] == polindrom[4] && polindrom[1] == polindrom[3])
{
    System.Console.WriteLine("Это полиндром");
}
else
{
    System.Console.WriteLine("это не полиндром");
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Введите координаты двух точек :");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double segment = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

double distance = Math.Round(segment, 2);
System.Console.WriteLine("Расстояние между точками : " + distance);


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите челое число :");
int number1 = Convert.ToInt32(Console.ReadLine);
int tablecube = 1;
if (number1 < 1)
{
    System.Console.WriteLine("Введите целое число ,равное единице, или больше единице : ");
}
while (tablecube <= 1)
{
    System.Console.Write(Math.Pow(tablecube, 3) + "; ");
    tablecube++;
}
