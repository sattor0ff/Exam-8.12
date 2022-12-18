int n, cnt=0; 
n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int j = 0; j<n-1; j++)
{
    if(arr[j] != arr[j+1])
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);