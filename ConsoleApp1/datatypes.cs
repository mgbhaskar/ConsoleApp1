using System;
class Datatypes
{
    static void Main()
    {
        byte age = 20;
        Console.WriteLine(age);
        Console.WriteLine();

        short number = 22;
        Console.WriteLine(number);


 

        Console.WriteLine("byte min value : " + byte.MinValue);
        Console.WriteLine("byte Max value : " + byte.MaxValue);
        Console.WriteLine();

        Console.WriteLine("short min value : " + short.MinValue);
        Console.WriteLine("short Max value : " + short.MaxValue);
        Console.WriteLine();

        Console.WriteLine("usshort min value : " + ushort.MinValue);
        Console.WriteLine("usshort Max value : " + ushort.MaxValue);
        Console.WriteLine();

        Console.WriteLine("int min value : " + int.MinValue);
        Console.WriteLine("int Max value : " + int.MaxValue);
        Console.WriteLine();

        Console.WriteLine("unit min value : " + uint.MinValue);
        Console.WriteLine("unit Max value : " + uint.MaxValue);
        Console.WriteLine();

        Console.WriteLine("long min value : " + long.MinValue);
        Console.WriteLine("long Max value : " + long.MaxValue);
        Console.WriteLine();

        Console.WriteLine("ulong min value : " + ulong.MinValue);
        Console.WriteLine("ulong Max value : " + ulong.MaxValue);
        Console.WriteLine();



        ///-----------boolean data--------
        ///


        bool correct = true;
        Console.WriteLine(correct);

        bool wrong = false;
        Console.WriteLine($"boolean wrong : {wrong}");


        //------------character------------


        char value = '1';
        Console.WriteLine(value);

    }
}
