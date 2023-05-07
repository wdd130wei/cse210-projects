using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        int menuUserinput = 0;

        List<string> menu = new List<string>
            {
                "Menu Options:",
                "   1. Start breathing activity",
                "   2. Start reflecting activity",
                "   3. Start listening activity",
                "   4. Quit",
                "Select a choice from the menu: "
            };

        while (menuUserinput != 4)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

            if (menuUserinput == 1)
            {
                BreathingActivity newBreathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                newBreathing.Breathing();
            }

            else if (menuUserinput == 2)
            {
                ReflectionActivity newReflecting = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                newReflecting.Reflection();
            }

            else if (menuUserinput == 3)
            {
                ListeningActivity newListening = new ListeningActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                newListening.Listening();
            }

            else if (menuUserinput == 4)
            {
                break;
            }
        }


    }
}