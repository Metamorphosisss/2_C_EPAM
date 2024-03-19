Console.WriteLine("вартiсть 1 ручки:");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("вартiсть 1 зошита:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("скiльки грошей має наш Петрик:");
double s = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("скiльки ручок вiн хоче купити:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("скiльки зошитів вiн хоче купити:");
int n = Convert.ToInt32(Console.ReadLine());

double overall = y * m +  x * n;

if (overall > s)
{
    Console.WriteLine("Петрик тут безсилий...");
}
else if (overall < 0)
{
    Console.WriteLine("Неможливий варiант :)");
}
else
{
    double left = s - overall;
    Console.WriteLine(left + " --> скiльки залишилось");
}