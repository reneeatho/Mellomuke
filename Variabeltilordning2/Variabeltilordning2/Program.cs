// See https://aka.ms/new-console-template for more information


{
    int a = 5;
    decimal b = 3.0M;
    double sum;
    sum = Multiply(a, b);
    Console.WriteLine(sum);
}

static double Multiply(int a , decimal b)
{
    double sum = (double)(a + b);
    return sum;

}

Console.ReadLine();

   