using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Blanka arrayer som senare ska spara data!
        string[] familyNames = new string[0];
        int[] familyAges = new int[0];



       //En evig while loop.
        while (true)
        {
            //Print Print Print...
            Console.WriteLine("Meny");
            Console.WriteLine("1. Add Family members");
            Console.WriteLine("2. Print Family members");
            Console.WriteLine("3. Print Sum of family members ages");
            Console.WriteLine("4. Print the avrage of all family members");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();
           //Switch 
            switch (choice)
            {

                case "1":
                    //Sparar mängden familje medlemar och gör storleken på array. 
                    Console.WriteLine("Enter the number of family members: ");
                    int familyNum = int.Parse(Console.ReadLine());
                    familyNames = new string[familyNum];
                    familyAges = new int[familyNum];


                    // For loop som samlar och sparar data från användaren i rätt ordning. 
                    for (int i = 0; i < familyNum; i++)
                    {
                        Console.WriteLine($"Enter the name of family member {i + 1}: ");
                        familyNames[i] = Console.ReadLine();
                        Console.WriteLine($"Enter the age of {familyNames[i]}: ");
                        familyAges[i] = int.Parse(Console.ReadLine());
                    }
                    break;


                case "2":

                    //Printar ut familjemedlarar med en for loop använder familyNames.Length eftersom familyNum kan inte nås.  
                    Console.WriteLine("Family Members: ");
                    for (int i = 0; i < familyNames.Length; i++)
                    {
                        Console.WriteLine($"Name: { familyNames[i]}");
                        Console.WriteLine($"Age:  {familyAges[i]}");

                    }

                    break;
            // En till for-loop som += alla åldrar till en result.
                case "3":
                    int result = 0;
                    Console.WriteLine("----Combined age----");
                    for (int i = 0; i < familyNames.Length; i++)
                    {
                        result += familyAges[i];
                    }
                    Console.WriteLine($"Sum of all ages:{result}");

                    break;


                case "4":
                    // Likande med case 3 += och sedan gör medain uträkning. 

                    {

                        int sumForMedian = 0;
                        for (int i = 0; i < familyAges.Length; i++)
                        {
                            sumForMedian += familyAges[i];
                        }

                        double median = (double)sumForMedian / familyAges.Length;
                        Console.WriteLine($"Average age: {median:F2}");
                    }


                    break;
             // Hoppar ut ur while loopen vilket effektivt avsultar programet.  
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
            }
        }
    }
}