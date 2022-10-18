Console.WriteLine();
/*Console.WriteLine("vvedite a i b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a / b; 
Console.WriteLine(c);
int ostatok = a % b;`
Console.WriteLine("ostatok"); */


/*Console.WriteLine("vvedite a i b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = (5 * a + b * b) / (b - a);
Console.WriteLine(c); */


/*Console.WriteLine("vvedite a i b");
string a = (Console.ReadLine());
string b = (Console.ReadLine());
string c = a;
a = b;
Console.WriteLine(a);
Console.WriteLine(c);*/


/*Console.WriteLine("vvedite a i b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int x = (c - b) / a;
Console.WriteLine(x); */


/*Console.WriteLine("vvedite a i b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a + b);

}
else if (a == b)
{
    Console.WriteLine(a * b);
}
else
{
    Console.WriteLine(a - b);
} */



/*Console.WriteLine("vvedite x i y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("tocka prinadlejit 1 cetvorti");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("tocka prinadlejit 2 cetvorti");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("tocka prinadlejit 3 cetvorti");
}
else
{
    Console.WriteLine("tocka prinadlejit 4 cetvorti");
} */



/*Console.WriteLine("vvedite cislo a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite cislo b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite cislo c");
int c = Convert.ToInt32(Console.ReadLine());
if (a <= b && a <= c && b <= c)
{
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
}
else if (a <= b && a <= c && c <= b)
{
    Console.WriteLine(a);
    Console.WriteLine(c);
    Console.WriteLine(b);
}
else if (b <= a && b <= c && a <= c)
{
    Console.WriteLine(b);
    Console.WriteLine(a);
    Console.WriteLine(c);
}
else if (b <= a && b <= c && c <= a)
{
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(a);
}
else if (c <= a && c <= b && b <= a)
{
    Console.WriteLine(c);
    Console.WriteLine(b);
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(c);
    Console.WriteLine(a);
    Console.WriteLine(b);
}
*/

/*Console.WriteLine("vvedite cislo a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite cislo b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite cislo c");
int c = Convert.ToInt32(Console.ReadLine());
double d = b * b - 4 * a * c;
if ( d > 0 )
{
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b + Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("x1 = {x2}, x2 = {x2}");
}
else if (d == 0)
{
    double x1 = (-b) / (2 * a);
    Console.WriteLine("x1= " + x1);
}
else
{
    Console.WriteLine();
} */


/*int number = Convert.ToInt32(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());
int temp =  number;
for (int i =1; i < power; i++)
{
    temp *= number;
}
Console.WriteLine(temp); */


/*int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= 1000; i++)
{
    if ( i% number == 0)
    Console.WriteLine(i);
}
 
*/

/*int number =  Convert.ToInt32(Console.ReadLine());
int kolicestvo = 0;
for (int i = 1; i * i < number; i++)
{
    kolicestvo += 1;
}
    Console.WriteLine(kolicestvo);
 */

/*Console.WriteLine("vvedite cislo a");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < a; i++)
{
    if ( a % i == 0)
    {
        Console.WriteLine(i);
    }

} 
*/


/*Console.WriteLine("vvedite cislo a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite cislo b");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = a + 1; i < b; i++)
{
    if ( i % 7 == 0 )
    {
        sum += 1;

    }
}
 Console.WriteLine(sum);  
*/


/*Console.WriteLine("vvedite cislo n")
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += 1;
}
Console.WriteLine(sum);
*/





