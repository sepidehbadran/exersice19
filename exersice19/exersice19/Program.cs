// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter the first number :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please enter the second number :");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max)
{
    max = num2;
}
int div = max / 10;
int rem = max % 10;
Console.WriteLine(" div = " + div);
Console.WriteLine(" rem = " + rem);
