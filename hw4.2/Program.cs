//Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(SumNum(num));

int SumNum(int number)
{
    int result = 0;
    int digit = 0;
    while (number > 0)
    {
        digit = number % 10;
        result = result + digit;
        number = number / 10;
    }
return result;
}