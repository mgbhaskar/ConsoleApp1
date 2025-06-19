using System;
using System.ComponentModel;

class operators
{
    static void Main()
    {

        Console.WriteLine("----------Arithmetic Operators------------");

        //Arithmetic Operators
        // + : Adds two operands.Example: 5 + 3 results in 8.
        // - : Subtracts the second operand from the first.Example: 10 - 4 results in 6.
        // * : Multiplies two operands.Example: 3 * 4 results in 12.
        // / : Divides the first operand by the second.Example: 10.0 / 3.0 results in approximately 3.3333.
        // % : Returns the remainder of a division operation.Example: 10 % 3 results in 1.


        int sum = 1 + 2;
        Console.WriteLine(sum);


       int minus = 5 - 2;
        Console.WriteLine(minus);

        int multiple = 3 * 3;
        Console.WriteLine(multiple);
        Console.WriteLine();

        

        int reminder = 3 % 10;
        Console.WriteLine(reminder);


        double divide =3.0 / 10.0;
        Console.WriteLine(divide);
        Console.WriteLine();


        Console.WriteLine("------------Comparision Operator-------------");

        // Comparison Operators it return the boolean
        // == : Checks if two operands are equal. Example: 5 == 5 results in true.
        // != : Checks if two operands are not equal. Example: 5 != 3 results in true.
        // > : Checks if the first operand is greater than the second. Example: 8 > 5 results in true.
        // < : Checks if the first operand is less than the second. Example: 3 < 7 results in true.
        // >= : Checks if the first operand is greater than or equal to the second. Example: 8 >= 8 results in true.
        // <= : Checks if the first operand is less than or equal to the second. Example: 3 <= 7 results in true.
      
        
        bool name = 5 == 5;
       bool name1= 5 != 6;
       bool name3=  5 > 4;
        bool name4 = 5 < 9;
        bool name5 = 5 >= 4;
        bool name6 = 5 <= 7;
        string name7 = $"{name},{name1},{name3},{name4},{name5},{name6}";
        Console.WriteLine(name7) ;
        Console.WriteLine();


        //      and operator


        //bool isthisTrueOrFalse = (10 == 10) && (10 != 11); //true
        //Console.WriteLine(isthisTrueOrFalse);

        //bool isthisTrueOrFalse1 = (6 == 6) && (5 == 3); //false
        //Console.WriteLine(isthisTrueOrFalse1);

        //bool isthisTrueOrFalse2 = (50 == 8) && (7 == 7); //false
        //Console.WriteLine(isthisTrueOrFalse2);

        //bool isthisTrueOrFalse3 = (99 == 8) && (5 == 3); //false
        //Console.WriteLine(isthisTrueOrFalse3);


        // ----------OR  ------------------
        bool isthisTrueOrFalse = (10 == 10) || (10 != 11); //true
        Console.WriteLine(isthisTrueOrFalse);

        bool isthisTrueOrFalse1 = (6 == 6) || (5 == 3); //true
        Console.WriteLine(isthisTrueOrFalse1);

        bool isthisTrueOrFalse2 = (50 == 8) || (7 == 7); //true
        Console.WriteLine(isthisTrueOrFalse2);

        bool isthisTrueOrFalse3 = (99 == 8) || (5 == 3); //false
        Console.WriteLine(isthisTrueOrFalse3);
        Console.WriteLine();


        bool oppTrue = !true;  //false
        Console.WriteLine(oppTrue);

        bool oppFalse = !false; //true
        Console.WriteLine(oppFalse);


        int age = 30;

        Console.WriteLine("Age is "+ age);


        int? age1 = 30;
        Console.WriteLine(age1);

        age1 = null;

        Console.WriteLine(age1);




    }

}