Console.Write("Введите число: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);

if (number1 % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}