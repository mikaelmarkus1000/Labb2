using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("How many family members do you have?");
        int familyNum = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Meny");
        //Console.WriteLine("1. Add Family members");
        //Console.WriteLine("2. Print Family members");
        //Console.WriteLine("3. Print Sum of family members ages");
        //Console.WriteLine("4. Print the avrage of all family members");





        string[] familyNames = new string[familyNum];
        string[] familyAges = new string[familyNum];

        for (int i = 0; i < familyNum; i++)
        {
            Console.WriteLine($"Enter the name of family member {i + 1}" );
            string enteredName = Console.ReadLine();
            familyNames[i] = enteredName;
            Console.WriteLine($"Enter the age of family member {i + 1}");
            string enteredAge = Console.ReadLine();
            familyAges[i] = enteredAge;



        }
        for (int i = 0; i < familyNum; i++)
        {
            Console.WriteLine(familyNames[i]);
            Console.WriteLine(familyAges[i]);

        }






    }




}