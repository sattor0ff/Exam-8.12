public class Factorial
{
    public long FactorialR(long n)
    {
        long fSum = 1;
        for(int i = 1; i<=n; i++)
        {
            fSum *= i;
        }
        return fSum;

    }
}