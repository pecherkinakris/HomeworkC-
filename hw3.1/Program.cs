Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()??"0");
int result1 = number/10;
int result2 = result1%10;
Console.WriteLine($"{result2}");
