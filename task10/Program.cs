Console.WriteLine("Если хотите узнать какая вторая цифра этого трехзначного числа");
Console.WriteLine("Введите трехзначное число");

int number1 = Convert.ToInt32(Console.ReadLine());

int a = number1 % 100;
int b = a / 10;

if (number1 > 99 && number1 < 999)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Неверное число");
}