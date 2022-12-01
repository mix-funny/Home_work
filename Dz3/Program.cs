Console.Clear();
Console.WriteLine("Введите число...");
int A = int.Parse(Console.ReadLine()!);
int result = A%2;

if(result == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}