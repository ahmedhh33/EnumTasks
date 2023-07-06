using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EnumTasks
{
    internal class Clothes
    {
        public ClothesSize clothesSize;
        public Clothes(ClothesSize clothesSize)
        {
            this.clothesSize = clothesSize;
        }
        public static void SearchClothesSize(String input)
        {
            

            ClothesSize clothesSize;
            try
            {
                clothesSize = (ClothesSize)Enum.Parse(typeof(ClothesSize), input.ToUpper());
            
            if (ClothesSize.SMALL == clothesSize)
            {
                Console.WriteLine($"FOR this size{ClothesSize.SMALL} 33 items available");
            }
            else if (ClothesSize.MEDIUM == clothesSize)
            {
                Console.WriteLine($"FOR this size{ClothesSize.MEDIUM} 67 items available");
            }
            else if (ClothesSize.LARGE == clothesSize)
            {
                Console.WriteLine($"FOR this size{ClothesSize.LARGE} 100 items available");
            }
            else if (ClothesSize.XLARGE == clothesSize)
            {
                Console.WriteLine($"FOR this size{ClothesSize.XLARGE} 23 items available");
            }
            else Console.WriteLine("");
            }
            catch(Exception e)
            {
                Console.WriteLine("You intered Wrong choices");
            }
        }
    }
    
    enum ClothesSize
    {
        SMALL,
        MEDIUM,
        LARGE,
        XLARGE
    }
}
