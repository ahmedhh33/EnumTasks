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
                    Console.WriteLine($"FOR this size{Favoritecolor.gray} 100 items available");
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
                    Console.WriteLine($"FOR this size{Favoritecolor.pink} 100 items available");
                }
                else if (Favoritecolor.purple == favoriteColor)
                {
                    Console.WriteLine($"FOR this size{Favoritecolor.purple} 23 items available");
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
