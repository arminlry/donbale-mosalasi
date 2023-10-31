// armin liryaee
// triangular sequence
// tamrin 6
 char a = ' ';
do
{

    Console.WriteLine("enter n number:");

    long n = Convert.ToInt64(Console.ReadLine());

   
    Console.WriteLine("enter m number");

    long m = Convert.ToInt64(Console.ReadLine());


    for (long t = n; t <= m; t++)
{           
        long o = t * (t + 1) / 2;

       
        Console.WriteLine(a);

        Console.WriteLine(o);


    }

    Console.WriteLine("do you want to continue?");
} while(Console.ReadLine() == "y");