using System;
using System.Collections.Generic;

namespace ApWorkouts
{
    class displayDrill
    {
        public static bool RunTest()
        {
            foreach (WorkoutDrill drill in workout)
            {
                Console.WriteLine(FormatWorkout(drill, displayAmount));
                {
                    WorkoutDrill squats = new WorkoutDrill("squats", 50);
                    WorkoutDrill calfRaise = new WorkoutDrill("calfRaise", 30);
                    WorkoutDrill legCurl = new WorkoutDrill("legCurl", 25);
                    WorkoutDrill deadLift = new WorkoutDrill("deadLift", 10);
                    WorkoutDrill walkingLunge = new WorkoutDrill("walkingLunge", 20);
                    WorkoutDrill legPress = new WorkoutDrill("legPress", 15);
                    WorkoutDrill stepUp = new WorkoutDrill("stepUp", 30);
                    WorkoutDrill wallSit = new WorkoutDrill("wallSit", 10);
                    WorkoutDrill bicepsCurl = new WorkoutDrill("bicepsCurl", 20);
                    WorkoutDrill pushUps = new WorkoutDrill("pushUps", 25);
                    WorkoutDrill tricepDip = new WorkoutDrill("tricepDip", 40);
                    WorkoutDrill plank = new WorkoutDrill("plank", 30);
                    WorkoutDrill sitUps = new WorkoutDrill("sitUps", 60);
                    WorkoutDrill vUps = new WorkoutDrill("vUps", 25);
                    WorkoutDrill treadmill = new WorkoutDrill("treadmill", 10);
                    WorkoutDrill stairMaster = new WorkoutDrill("stairMaster", 10);
                    WorkoutDrill jumpingJack = new WorkoutDrill("jumpingJack", 40);
                    WorkoutDrill burpee = new WorkoutDrill("burpee", 40);
                    WorkoutDrill bike = new WorkoutDrill("bike", 10);
                    WorkoutDrill jumpRope = new WorkoutDrill("jumpRope", 60);

                    legsDrill.Add(squats);
                    legsDrill.Add(calfRaise);
                    legsDrill.Add(legCurl);
                    legsDrill.Add(deadLift);
                    legsDrill.Add(walkingLunge);
                    legsDrill.Add(legPress);
                    legsDrill.Add(stepUp);
                    legsDrill.Add(wallSit);

                    armsAndAbsDrill.Add(bicepsCurl);
                    armsAndAbsDrill.Add(pushUps);
                    armsAndAbsDrill.Add(tricepDip);
                    armsAndAbsDrill.Add(plank);
                    armsAndAbsDrill.Add(sitUps);
                    armsAndAbsDrill.Add(vUps);

                    cardioDrill.Add(treadmill);
                    cardioDrill.Add(stairMaster);
                    cardioDrill.Add(jumpingJack);
                    cardioDrill.Add(burpee);
                    cardioDrill.Add(bike);
                    cardioDrill.Add(jumpRope);
                    
                    SelectRecipe(true);
                }
            }
        }
    }
}