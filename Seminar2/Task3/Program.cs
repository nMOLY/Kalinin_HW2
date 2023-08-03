Console.WriteLine("Введите день недели цифрой");
int randomNumber = int.Parse(Console.ReadLine());
if (randomNumber > 5)
{
    Console.WriteLine(randomNumber + " -> да");
}
else
{
    Console.WriteLine(randomNumber + " -> нет");
}