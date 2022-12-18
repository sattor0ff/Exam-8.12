Multiple multiple = new Multiple();
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Multiply : {a} * {b} = {multiple.Multiply(a,b)}");


Division division = new Division();
int c, d;
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Division : {c} / {d} = {division.DivisionA(c,d)}");


Factorial factorial = new Factorial();
long n;
n = Convert.ToInt64(Console.ReadLine());

System.Console.WriteLine($"Factorial : {n} is {factorial.FactorialR(n)}");