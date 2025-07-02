using System;

class Tasks
{
    static void Main()
    {
        // 1. Prepareing the String Array
        string[] employees = { "John", "Robert", "Chandra", "Peter" };

        Console.WriteLine("2) Get the Third Employe Array");
        Console.WriteLine("Third employee: " + employees[2]);
        Console.WriteLine();



        Console.WriteLine("3) Check Whether Second and Third Employee are Equal");
        bool equalsOrNot = employees[1] == employees[2];
        Console.WriteLine("Second and Third are equal: " + equalsOrNot);
        Console.WriteLine();



        Console.WriteLine("4) Check the Employee Whose Name Starts with J");
        foreach (string emp in employees)
        {
            if (emp.StartsWith("J"))
            {
                Console.WriteLine("Employee starting with J: " + emp);
            }
        }
        Console.WriteLine();



        Console.WriteLine("5) Convert Employees List into Single String");
        string singleString = string.Join(", ", employees);
        Console.WriteLine("All employees: " + singleString);
        Console.WriteLine();



        Console.WriteLine("6) Replace 'Robert' with 'Peter' in the String");
        string replaced = singleString.Replace("Robert", "Peter");
        Console.WriteLine(replaced);
        Console.WriteLine();



        Console.WriteLine("7) Get Employees Whose Name Length > 4 Characters");
        foreach (string emp in employees)
        {
            if (emp.Length > 4)
            {
                Console.WriteLine("Name > 4 characters: " + emp);
            }
        }
        Console.WriteLine();



        Console.WriteLine("8) Difference Between for and foreach");
        Console.WriteLine("Using for:");
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i]);
        }

        Console.WriteLine("Using foreach:");
        foreach (string emp in employees)
        {
            Console.WriteLine(emp);
        }
        Console.WriteLine();




        Console.WriteLine("9) Importance of Looping System with Example");
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Welcome " + employees[i]);
        }
        Console.WriteLine();




        Console.WriteLine("10) What Are Floating Data Types? Example");
        float pi = 3.14f;
        double price = 99.99;
        decimal salary = 12345.67m;
        Console.WriteLine(pi);
        Console.WriteLine(price);
        Console.WriteLine(salary);
        Console.WriteLine();




        Console.WriteLine("11) What are Logical Operators? Importance & Example");
        int age = 25;
        bool isCitizen = true;
        if (age >= 18 && isCitizen)
        {
            Console.WriteLine("Eligible to vote");
        }
        else
        {
            Console.WriteLine("Not eligible");
        }
        Console.WriteLine();




        Console.WriteLine("12) What is Nullable Type? Example");
        int? value = null;
        if (value.HasValue)
        {
            Console.WriteLine("Value is " + value.Value);
        }
        else
        {
            Console.WriteLine("Value not provided");
        }
        Console.WriteLine();




        Console.WriteLine("13) What is Implicit Conversion Type? Example");
        int num = 1000;
        double d = num;  // Implicit conversion
        Console.WriteLine(d);
        Console.WriteLine();




        Console.WriteLine("14) Prepare Method with Params and Return Type");
        int Add(int a, int b)
        {
            return a + b;
        }
        int sum = Add(10, 20);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine();




        Console.WriteLine("15) Method with Conditions (if, else if, else)");
        void CheckNumber(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("Positive number");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negative number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
        CheckNumber(5);
        CheckNumber(-3);
        CheckNumber(0);
        Console.WriteLine();




        Console.WriteLine("16) Method with Conditions (switch case)");
        void DayName(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("thursaday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
        DayName(1);
        DayName(2);
        DayName(7);
        Console.WriteLine();




        Console.WriteLine("17) Method with if else if else and switch case");
        void CheckGrade(int score)
        {
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: C or below");
            }

            switch (score / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("Excellent");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("Needs improvement");
                    break;
            }
        }
        CheckGrade(95);
        CheckGrade(80);
        CheckGrade(60);
    }
}
