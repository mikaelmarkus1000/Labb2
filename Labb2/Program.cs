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

        string[] familyName = new string[familyNum];

        for (int i = 0; i < familyNum; i++)
        {
            Console.WriteLine("Enter the name of family member");
            string enteredName = Console.ReadLine();
            familyName = new string[] { enteredName };
            




        }
        Console.WriteLine(familyName);
        




    }




}