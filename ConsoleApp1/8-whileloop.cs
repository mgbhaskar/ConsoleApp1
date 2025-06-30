using System;
using System.Threading;


class whileloop
{
    static void Main()
    {
        //    int count = 0;
        //    while (count <5)
        //    {
        //        Console.WriteLine("statement executed...");
        //        count = count + 1;
        //}
        //}
        int myindiancurrency = 0;

        Console.WriteLine($"my currency is before while loop: {myindiancurrency}");

        while (myindiancurrency < 5)
        {
            //myindiancurrency = myindiancurrency + 1;
            Console.WriteLine(myindiancurrency);
            myindiancurrency++;

        }
        int[] currency = { 50, 100, 100, 200, 300 };
        int countingstage = 0;
        int totalamount = 0;
        while (countingstage < currency.Length)
        {
            Console.Write(currency[countingstage]);

        }
    }
}
