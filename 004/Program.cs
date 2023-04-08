Console.Write("Введите число: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);

int count = 2;
while (count <= number1)
{
    Console.Write(count);
    Console.Write(" ");
    count += 2;
}