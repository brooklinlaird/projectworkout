using System;
using System.Collections.Generic;

namespace ApWorkouts
{
    class selectWorkout
    {
        public static bool RunTest()
        {
            while (true)
            {
                Console.WriteLine("Welcome to your online workout! Do you want to work on strengthing your [legs], [arms and abs], or [cardio]?");
                string reply = Console.ReadLine();
                if (reply.Equals("legs"))
                {
                    if (displayAmount)
                    {
                        displayDrill(legsWorkout, true);
                    }
                    else
                    {
                        displayDrill(legsWorkout, false);
                    }
                    return;
                }
                else if (reply.Equals("arms and abs"))
                {
                    displayDrill(armsWorkout, displayAmount);
                    return;
                }
                else if (reply.Equals("cardio"))
                {
                    displayDrill(absWorkout, displayAmount);
                    return;
                }
                else
                {
                    Console.WriteLine("Please pick a workout from the list");
                }
            }
        }
    }
}