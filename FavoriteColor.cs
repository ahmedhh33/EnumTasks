using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTasks
{
    internal class FavoriteColor
    {
        public Favoritecolor favoritecolor;
        public FavoriteColor(Favoritecolor favoritecolor)
        {
            this.favoritecolor = favoritecolor;
        }
        public static void DiscoverYourFavoriteColor(int input)
        {
            try
            {

                Favoritecolor favoritecolor = (Favoritecolor)input;//used to cast the integer input to the Favoritecolor enum type.
                if (Favoritecolor.green == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());//print the enums
                }
                else if (Favoritecolor.red == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.gray == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.yellow == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.black == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.blue == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.brown == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.orange == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.pink == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.purple == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());
                }
                else if (Favoritecolor.white == favoritecolor)
                {
                    Console.WriteLine(favoritecolor.ToString());

                }
                else Console.WriteLine();
            }catch(Exception ex)
            {
                Console.WriteLine("Wronge choisee");
            }


        }
        public static void CheckYourFavoriteColor(String input)
        {


            Favoritecolor favoriteColor;
            try
            {
                favoriteColor = (Favoritecolor)Enum.Parse(typeof(Favoritecolor), input.ToLower());
                if (Favoritecolor.green == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.green} 33 items available");
                }
                else if (Favoritecolor.red == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.red} 67 items available");
                }
                else if (Favoritecolor.gray == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.gray} 10 items available");
                }
                else if (Favoritecolor.yellow == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.yellow} 23 items available");
                }
                else if (Favoritecolor.black == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.black} 67 items available");
                }
                else if (Favoritecolor.blue == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.blue} 100 items available");
                }
                else if (Favoritecolor.brown == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.brown} 23 items available");
                }
                else if (Favoritecolor.orange == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.orange} 67 items available");
                }
                else if (Favoritecolor.pink == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.pink} 5 items available");
                }
                else if (Favoritecolor.purple == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.purple} 2573 items available");
                }
                else if (Favoritecolor.white == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.white} 65 items available");
                }
                else Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("You intered Wrong choices");

            }
        }
    }
    
    
    enum Favoritecolor
    {
        red, 
        orange, 
        yellow, 
        green, 
        blue, 
        purple, 
        pink, 
        brown, 
        black, 
        gray, 
        white
    }
}
