using System;
class VarAndDynamic

{
     static void Main()
    {
        int value = 20;
        value = 30;
        Console.WriteLine(value);
        Console.WriteLine();

        string name = "bhaskar";
        name = "c#.Net";
        Console.WriteLine(name);
        Console.WriteLine();

        double prices = 121.2;
        prices = 22.5;
        Console.WriteLine(prices);
        Console.WriteLine();

        //     ------------ * Var * --------------- //


        var number = 10;
        Console.WriteLine("var number is : " + number);
        Console.WriteLine("data type is : "+number.GetType());


        var v_name = 10;
        Console.WriteLine("v_name number is : " + v_name);
        Console.WriteLine("data type is : " + v_name.GetType());
Console.WriteLine();

        //----------------  dynamic  ------------

        dynamic d_number = 10;
        d_number = 30;
        Console.WriteLine("d_number is : " +d_number);
        Console.WriteLine("d_number data type : "+d_number.GetType());
        Console.WriteLine();

        dynamic d_name= "C#.Net";
        Console.WriteLine(d_name);
        Console.WriteLine("d_name dtaatype : " + d_name.GetType());




        d_name = "TCS";
        Console.WriteLine(d_name.GetType());

        Console.WriteLine($"v_name {d_name.Length}");

        dynamic d_price = 12.5d;        
        d_price = "Misard";
        Console.WriteLine(d_price.GetType()); 




    }


}
