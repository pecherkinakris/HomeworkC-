Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine()??"0");
int result=0;
int result1=0;
if (numb<99)
{
    Console.WriteLine("Третьей цифры нет!");
}
while (numb>1000)
{
    result=numb/10;
    numb=result;
}
result1=result%10;
Console.WriteLine($"{result1}");
