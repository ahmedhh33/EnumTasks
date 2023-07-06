namespace EnumTasks
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


        }
    }
}