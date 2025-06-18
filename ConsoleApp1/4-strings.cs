using System;
using System.Runtime.CompilerServices;

class bhaskar
{
    static void Main()
    {

        // string name = "bhaskar";
        // byte age = 23;
        // Console.WriteLine($"Name is {name} and age is {age} years old");
        // Console.WriteLine();

        // string namescount = "Name is Bhaskar m";
        //int count = namescount.Length;
        // Console.WriteLine(count);

        //string name = "Guru Bhaskar Reddy";
        //string convertuppercase =name.ToUpper();
        //Console.WriteLine(convertuppercase);
        //Console.WriteLine();

        //string names = "Guru Bhaskar Reddy";
        //string convertLowerCase =names.ToLower();
        //Console.WriteLine(convertLowerCase);


        //string names = "      bhaskar      ";
        //Console.WriteLine(names);
        //string trimspace =names.Trim();
        //Console.WriteLine(trimspace);


        //string names1 ="*****************bhaskar*****************";
        //Console.WriteLine(names1);
        //string RemoveStarsBeforeName = names1.TrimStart('*');
        //Console.WriteLine(trimspace1);
        //Console.WriteLine(RemoveStarsBeforeName);


        // string name = "bhaskar123@";
        //bool compare =name.Equals("bhaskar");
        // Console.WriteLine($"isCorrect : {compare}");


        //string name = "name is guru bhaskar reddy";
        //string update =name.Substring(4);
        //Console.WriteLine(update);
        //string newname = name.Substring(4, 8);
        //Console.WriteLine(newname);


        string name = "This is Japan";
        string replacename = name.Replace("Japan", "India");
        Console.WriteLine(replacename);


        string name1 = "Bhaskar";
        int age = 23;
        string result = string.Format("Name: {0}, Age: {1}", name1, age);
        Console.WriteLine(result);




    }

}