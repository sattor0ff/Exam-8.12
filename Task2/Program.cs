int n, minn=0, maxx=0, minIndex=0, maxIndex = 0; 
n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
    minn = arr[0];
    maxx = arr[0];
for (int j = 0; j<n; j++)
{
    
    if(arr[j] < minn)
    {
        minn = arr[j];
    }
    if(arr[j] > maxx)
    {
        maxx = arr[j];
    }
}
for (int i=0; i<n; i++)
{
    if(arr[i] != minn)
    {
    minIndex += 1;
    }
    if(arr[i] == minn)
    {break;}
}
for (int i=0; i<n; i++)
{
    if(arr[i] != maxx)
    {
    maxIndex += 1;
    }
    if(arr[i] == maxx)
    {break;}
}
System.Console.WriteLine();
for(int i = arr[minIndex]; i<arr[maxIndex]-1; i++)
{
    System.Console.Write($"{arr[i]} ");
}
