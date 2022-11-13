//Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.
Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(Exp(num1, num2));



int Exp(int number1, int number2)
{   
   int result = 1;
   for(int i = 0; i < number2; i++)
   {
    result = result * number1;
   }
    //int i = 0;
    //while (i < number2)
    //{
        //result = result * number1;
        //i++;
    //}
    return result;
}
