using System;
using System.Collections.Generic;
using System.IO;

namespace ApWorkouts
{
    class FormatWorkout
    {
        public static bool RunTest()
        {
            if (displayAmount)
            {
                return " ~ " + workout.name + "... " + drill.amount + "reps";
            }
            return " ~ " + workout.name;
        }
    }
}