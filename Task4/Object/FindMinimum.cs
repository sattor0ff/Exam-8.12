public class Minimum
{
 public int FindMinimum(int a, int b, int c, int d)
 {
    int minn=0;
    if(a<b && a<c && a<d)
    {minn = a;}
    else if(b<a && b<c && b<d)
    {minn = b;}
    else if(c<a && c<b && c<d)
    {minn = c;}
    else
    {minn = d;}
    return minn;
 }
}