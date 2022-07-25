using System;
using System.Threading;

namespace cSharp5
{
    public class AppointmentManager
    {
        public static void Main(string[] args)
        {
            Patient[,] appList = new Patient[31, 4];
            while (true)
            {
                Console.Clear();
                Menue();
                string command = Console.ReadLine();
                Console.Clear();
                if (command == "1")
                {
                    System.Console.Write("please enter the day: ");
                    int day = int.Parse(Console.ReadLine());
                    System.Console.Write("please enter time: ");
                    int time = int.Parse(Console.ReadLine());
                    bool x = isAvailable(appList, day, time);
                    addPatient(appList, day, time, x);
                }
                else if (command == "2")
                {
                    System.Console.WriteLine("this months schedule: ");
                    printPatientlist(appList);
                    Console.ReadKey();
                }
                else if (command == "3")
                {
                    System.Console.WriteLine("bye.");
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    System.Console.WriteLine("try egain: ");
                    Thread.Sleep(1000);
                }
            }
        }

        private static bool isAvailable(Patient[,] appList, int day, int time)
        {
            if (appList[day, time] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void printPatientlist(Patient[,] appList)
        {
            for (var i = 0; i < appList.GetLength(0); i++)
            {
                System.Console.WriteLine($"day {i}:");
                for (var j = 0; j < appList.GetLength(1); j++)
                {
                    if (appList[i, j] != null)
                        Console.WriteLine($" {j}. {appList[i, j].Name} {appList[i, j].LastName}");
                }
            }
        }
        private static void addPatient(Patient[,] appList, int day, int time, bool isAvailable)
        {
            if (isAvailable)
            {
                appList[day, time] = new Patient();
                System.Console.Write("please enter your name: ");
                appList[day, time].Name = Console.ReadLine();
                System.Console.Write("please enter your last name: ");
                appList[day, time].LastName = Console.ReadLine();
                Console.WriteLine("done.");
                Thread.Sleep(1500);
            }
            else
            {
                System.Console.WriteLine("sorry, its full... try again.");
                Thread.Sleep(1200);
            }
        }
        private static void Menue()
        {
            Console.WriteLine("Hello, Welcome to our appointmen program.");
            System.Console.WriteLine("pls enter your command: ");
            System.Console.WriteLine("1. add appointment.");
            System.Console.WriteLine("2. see the schedule.");
            System.Console.WriteLine("3. Exit.");
        }
    }
}
