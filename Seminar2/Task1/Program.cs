int randomNumber = new Random().Next(100, 1000);
Console.WriteLine("Случайное число " + randomNumber);
randomNumber = (randomNumber / 10) % 10;
Console.WriteLine("2 цифра случайного числа равна " + randomNumber);