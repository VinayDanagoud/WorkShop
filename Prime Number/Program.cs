
Console.WriteLine("welcome to prime Number ");
{
    int n, i, m = 0, sum = 0;
    Console.WriteLine("Enter the Number to check prime");
    n = Convert.ToInt32(Console.ReadLine());
    m = n / 2;
    for (i = 2; i <= m; i++)
    {
        if (n % i == 0)
        {
            Console.WriteLine("Number is not prime");
            sum = 1;
            break;
        }
    }
    if (sum == 0)
        Console.WriteLine("Number is prime");
}