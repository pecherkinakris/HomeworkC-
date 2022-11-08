Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()??"0");
if (number==1)
    {
        Console.WriteLine("X: 0, +бесконечность");
        Console.WriteLine("Y: 0, +бесконечность");
    }
if (number==2)
    {
        Console.WriteLine("X: 0, -бесконечность");
        Console.WriteLine("Y: 0, +бесконечность");
    }
if (number==3)
    {
        Console.WriteLine("X: 0, -бесконечность");
        Console.WriteLine("Y: 0, -бесконечность");
    }
if (number==4)
    {
        Console.WriteLine("X: 0, +бесконечность");
        Console.WriteLine("Y: 0, -бесконечность");
    }
if (number>4)
{
    Console.WriteLine("Такой четверти не существует. Введите число от 1 до 4.");
}
if (number<1)
{
    Console.WriteLine("Такой четверти не существует. Введите число от 1 до 4.");
}