﻿namespace EnumTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Console.WriteLine("Enter The Day");

            string input = (Console.ReadLine());//input days
            string days = input.ToUpper();//to upper letter
            DaysOfWeek.Dayscheduale(days);//task1
            Console.WriteLine();

            Console.WriteLine("Task2");
            Console.Write("Enter Youre size to show the  number of iteme available :");
            Console.WriteLine();
            String input2 = Console.ReadLine();
            Clothes.SearchClothesSize(input2);
            Console.WriteLine();


            Console.WriteLine("Task3");
            Console.Write("Enter Youre favorite color to see the number of shirts that have that color :");
            Console.WriteLine();
            String input3 = Console.ReadLine();
            FavoriteColor.CheckYourFavoriteColor(input3);
            Console.WriteLine();

            Console.WriteLine("Task4");
            Console.Write("Enter number from 0 to 10 :");
            Console.WriteLine();
            int input4 = int.Parse(Console.ReadLine());
            FavoriteColor.DiscoverYourFavoriteColor(input4);
            Console.WriteLine();

            Console.WriteLine("Task5");
            Console.WriteLine("Enter duration togking light in millisecond ");
            int PuseDuration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of iteration sequence you need ");
            int iterationsequence = int.Parse(Console.ReadLine());
            TrafficLights.TrafficLightSequence(PuseDuration, iterationsequence);

        }
    }
}