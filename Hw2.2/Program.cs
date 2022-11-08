Console.WriteLine("Введилте два числа");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

if (Math.Sqrt(a) == b)
{
    Console.WriteLine("a является квадратом b");
}
if (Math.Sqrt(b) == a)
{
    Console.WriteLine("b является квадратом a");
}
else 
{
    Console.WriteLine("Не являются квадратами");
}