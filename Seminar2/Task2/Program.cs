Console.WriteLine("Введите любое число");
int randomNumber = int.Parse(Console.ReadLine());
if (randomNumber > 100)
{
randomNumber = (randomNumber / 100) % 10;
Console.WriteLine("3 цифра заданного числа равна " + randomNumber);
}
else
{
    Console.WriteLine("Такого числа нет");
}