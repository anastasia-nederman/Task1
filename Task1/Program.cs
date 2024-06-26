﻿namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Uppgift 1
            Klasser:
            - anställd

            Uppgift 2
            Attribut:
            - namn
            - lön
            Metoder:
            - att lägga till en anställd till registret
            - att visa hela registret 
            
            Men jag kan inte skriva klasser, attributer och metoder än. Därför är mitt program enkelt.
            */

            Console.WriteLine("Hello! How many employees do you have? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            string[] employee = new string[numberOfEmployees];
            int[] salary = new int[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Please add the name of employee: ");
                employee[i] = Console.ReadLine();
                Console.WriteLine("Great, now add the salary of the employee (SEK / month): ");
                salary[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you! Here is the list of employees:");
            Console.WriteLine("Employee Salary (SEK / month)");

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine(employee[i] + " " + salary[i]);
            }            
        }
    }
}
