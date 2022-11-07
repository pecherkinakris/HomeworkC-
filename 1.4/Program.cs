Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int x = 0;

if (num%2 ==0)
{
while (x <= num)
{
  Console.WriteLine(x+2);
  x=x+2;  
}    
}
else{
    while(x<= num-1)
{
   Console.WriteLine(x+2);
    x=x+2; 
}
}