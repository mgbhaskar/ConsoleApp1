using System;


    class nothig
    {
        static void main()
        {
        string[] student_names = { "Mahesh,NTR,Chaitanya,Ram" };
        int count = 0;
        while (count < student_names.Length)
        {
            Console.WriteLine($"List of students is {student_names[count]}");
            count = count + 1;
        }
    }

    }

