

namespace Lesson1 { 

class Program
{
     static void Main(string[] args)
    {
            /*int x = 6;
            int y = 7;
            int c = x + y;
            Console.WriteLine(c);*/

/* int x, y, z;
 Console.WriteLine("Enter first number");
 x=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter second number");
 y = Convert.ToInt32(Console.ReadLine());

 z = x + y;
 Console.WriteLine(z);*/

/*int z = Sum(15, 23); //1-ci burda cagirdim
Console.WriteLine(z);*/

/* Sum funksiyasina aid 2-ci numune 
 * Console.WriteLine("Enter first number");
int  x = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter second number");
int  y = Convert.ToInt32(Console.ReadLine());
 int result = Sum(x,y);
 Console.WriteLine("Sum is: "+ result);
 Console.ReadLine();
 Console.ReadKey();*/



Console.WriteLine("Enter first number");
int x;

while (true)
{
    try
    {
         x = Convert.ToInt32(Console.ReadLine());
        break;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Siz ancaq reqem daxil etmelisiniz");
    }

}
int y;
Console.WriteLine("Enter second number");
while (true)
{
    try
    {
        y = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch (Exception ex


    ) 
    {
        Console.WriteLine("Siz ancaq reqem daxil etmelisiniz");
    }

}
int result = Sum(x, y);
Console.WriteLine("Sum is: " + result);
}
public static int Sum(int x, int y)// 1-ci Sum funksiyanini  
{ 
return x + y;

}

}
}