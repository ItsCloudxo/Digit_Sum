int n, sum = 0;

bool isNumber = int.TryParse(Console.ReadLine(), out n);
n = Math.Abs(n);

if (isNumber)
{
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Number wasn't an input");
}