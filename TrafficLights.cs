using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTasks
{
    internal class TrafficLights
    {
        public static void TrafficLightSequence(int duration,int iteration)
        {
            for (int i = 0; i < iteration; i++)
            {
                foreach (TrafficLight currentlight in Enum.GetValues(typeof(TrafficLight)))
                {
                    Console.WriteLine($"The Current light color now is: {currentlight}");
                    Thread.Sleep(duration);
                }
            }
        }
    }
    enum TrafficLight
    {
        RED,
        YELLOW,
        GREEN
    }
}
