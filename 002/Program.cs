Console.Write("Введите число A: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите число B: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);
Console.Write("Введите число C: ");
string text3 = Console.ReadLine();
int number3 = Convert.ToInt32(text3);

int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.Write("Максимальное число: ");
Console.WriteLine(max);