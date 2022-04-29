using System;

namespace projectworkout
{
    class MainClass
    {
        static List<WorkoutDrill> legsDrill = new List<WorkoutDrill>();
        static List<WorkoutDrill> armsAndAbsDrill = new List<WorkoutDrill>();
        static List<WorkoutDrill> cardioDrill = new List<WorkoutDrill>();

        public static String formatWorkout(WorkoutDrill item, bool displayAmount)
        {
            if (displayAmount)
            {
                return " ~ " + workout.name + "... " + drill.amount + "reps";
            }
            return " ~ " + workout.name;
        }

        public static void displayDrill(List<WorkoutDrill> workouts, bool displayAmount)
        {
            {
                foreach (Workout drill in gym)
                {
                    Console.WriteLine(FormatWorkout(drill, displayAmount));
                }
            }

            static void SelectWorkout(bool displayAmount)
            {
                while (true)
                {
                    Console.WriteLine("Welcome ApWorkout your online workout! Do you want to work on strengthing your [legs], [arms and abs], or [cardio]?");
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

        public static void Main(string[] args)
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

            SelectWorkout(true);
        }
    }

    class WorkoutDrill
    {
        public string name;
        public double amount;

        public WorkoutDrill(string name, double amount)
        {
            this.name = name;
            this.amount = amount;

        }
    }
}