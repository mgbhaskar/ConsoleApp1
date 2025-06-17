using System;

class String
{
    static void Main()
    {
        string strCourseName = "Csharp";  

        string strCourseName1 = "\"Csharp\"";  
        Console.WriteLine(strCourseName1);

        string numberStrings = "One.\nTwo.\nThree"; 
        Console.WriteLine(numberStrings);

        string myProjectPath = @"D:\Csharp - Training\\CSharp\\CSharp_Step1\";
        Console.WriteLine(myProjectPath);

        
        string name = "bhaskar";
        int age = 23;
        string message = $"My name is {name} and i am {age} yeals old";

        Console.WriteLine(message);
       
    }

}