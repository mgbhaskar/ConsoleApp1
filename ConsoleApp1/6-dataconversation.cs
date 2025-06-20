using System;

class dataconversion
{
    static void Main()
    {

        //Implicit Conversions



        //byte → short → int → long → float → double

        //          byte → int

        //         int → float

        //        float → double


        byte smallNumber = 255;
        int largeNumber = smallNumber; 
        Console.WriteLine(largeNumber);
        Console.WriteLine();


        //

        int NoOfEmployees = 1000;     // casting is data
        byte ConvertingNoOfEmployees = (byte)NoOfEmployees;
        Console.WriteLine(ConvertingNoOfEmployees);   //  o/p= 144 ==> 1000 - 256 =744-256 =488-256=232


    }

}