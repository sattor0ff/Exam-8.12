int n, nSum=0, facSum=1; 
n = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i<=n; i++)
{
    facSum = 1;
    for(int j = 1; j<=i; j++)
    {
        facSum = facSum*2;
    }
    nSum+=facSum;
}
System.Console.WriteLine(nSum);
