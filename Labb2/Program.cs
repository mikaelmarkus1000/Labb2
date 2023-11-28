using System;
using System.Collections.Generic;
class Program
{
    static void Main() { 

        string[] familyNames = new string[0];
        int[] familyAges = new int[0];


    
        
        while (true)
        {
            Console.WriteLine("Meny");
            Console.WriteLine("1. Add Family members");
            Console.WriteLine("2. Print Family members");
            Console.WriteLine("3. Print Sum of family members ages");
            Console.WriteLine("4. Print the avrage of all family members");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice) {

                case "1":

                    Console.WriteLine("Enter the number of family members: ");
                    int familyNum = int.Parse(Console.ReadLine());

                    familyNames = new string[familyNum];
                    familyAges = new int[familyNum];

                    for (int i = 0; i < familyNum; i++)
                    {
                        Console.WriteLine($"Enter the name of family member {i + 1}: ");                       
                        familyNames[i] = Console.ReadLine();
                        Console.WriteLine($"Enter the age of family {familyNames[i]}: ");
                        familyAges[i] = int.Parse(Console.ReadLine());

                    }
                    break;






                    
                
                        
                        
              case "2":


                    Console.WriteLine("Family Members: ");
                    for (int i = 0; i < familyNames.Length; i++)
                    {
                        Console.WriteLine($"Name: { familyNames[i]}");
                        Console.WriteLine($"Age:  {familyAges[i]}");

                    }

                    break;

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



                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                    
                    
               break;

            }
        }
    




        




    }




}