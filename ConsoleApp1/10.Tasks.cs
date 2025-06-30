using System;


    class tasks
    {
    static void Main() 
    
    {
     

        /*

                           Employees Data : 
                           1.  “John, Robert, Chandra, Peter”
                           2. [“John”, “Robert”, “Chandra”, Peter”]




                      1.Prepare the String Array 

                      2.Get the Third Employee from the Array

                      3.Check weather Second and Third employee Equals or not from the Array

                      4.Check the employee whose name starts with “J” from the Array

                       5.Convert Employees List into single String

                       6.Replace the “Robert” with “Peter” in String

                      7. Get the Employee whose name length is more that 4 charcters from the array

                       8.Diff b/w for and foreach ? Explain with example

                       9.Explain me what is the importance of the Looping system. ? Explain with Example

                        10.What are the floating data types ? EXample

                        11.What are the Logical operators importance of that ? Explain with example

                       12.What is the nullable types ? Example

                       13.What is implicit conversation type ? Example

                       14.Prepare the Method with params with return types.

                       15.Prepare the Methods with conditions (if elseif else)

                       16.Prepare the methods with Conditions (switch case)

                       17.Prepare the Methods with if else if else and Switch case conditions.


      */
        //                        0        1         2          3
        string[] employees = { "John", "Robert", "Chandra", "Peter" };

        Console.WriteLine("2) Get the Third Employee from the Array");
        Console.WriteLine("Third employee: " + employees[2]); 
        Console.WriteLine();


        Console.WriteLine(" 3) Check Whether Second and Third Employee are Equal");
        bool Equalsornot = employees[1] == employees[2];
        Console.WriteLine("Second and Third are equal: " + Equalsornot);
        Console.WriteLine();


        Console.WriteLine("4) Check the Employee Whose Name Starts with J ");
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
        Console.WriteLine("All employees: " + singleString);       //ALL NAMES ExecUTED
        Console.WriteLine();



        Console.WriteLine(" 6) Replace “Robert” with “Peter” in the String");
        string replaced = singleString.Replace("Robert", "Peter");
        Console.WriteLine(replaced);
        Console.WriteLine();



        Console.WriteLine("7) Get Employees Whose Name Length > 4 Characters");
        foreach (string emp in employees)
        {
            if (emp.Length > 4)
            {
                Console.WriteLine("Name > 4 characters: " + emp);
                // Output: Robert, Chandra, Peter
            }
        }
        Console.WriteLine();



        Console.WriteLine("8) Difference Between for and foreach");
        
        for (int i = 1; i < employees.Length; i++)
        {
            Console.WriteLine("Using for: " + employees[i]);                //  for is modify items
        }
 
;

        foreach (string emp in employees)
        {
            Console.WriteLine("Using foreach: " + emp);        //   foreach  Only read items (not modify),
        }

        Console.WriteLine();



        Console.WriteLine("9) Importance of Looping System with Example");  // this is instead of writiong

        /*
             To avod repetive code

             Handle collections (like arrays, lists)

             Automate operations (e.g., printing, filtering)
         */
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Welcome " + employees[i]);
        }
        Console.WriteLine();

        Console.WriteLine("10) What Are Floating Data Types?");
        float pi = 3.14f;
        double price = 99.99;
        decimal salary = 12345.67m;
        Console.WriteLine(pi);
        Console.WriteLine();




        Console.WriteLine("11. What are the logical operators? Importance & example");
        /*
            operators two types --> And not symbols is && , !
        Importance:is
        Combine multiple conditions in if, while, for,
        Control complex decision-making.

        */



    }
}
