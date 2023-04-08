Console.Write("Введите число A: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите число B: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);

if (number1 > number2)
{
    Console.WriteLine("Число А больше, чем B");
}
else if (number1 < number2)
{
    Console.WriteLine("Число B больше, чем A");
}
else
{
    Console.WriteLine("Числа A и B равны");  
}