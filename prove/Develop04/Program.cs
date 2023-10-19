using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        while (userChoice != 4)
        {
            string mainMenu = "Menu Options:\n\n1. Start Breathing Activity\n2. Start Listing Activity\n3. Start Reflecting Activity\n4. Quit\n\nSelect a choice from the menu: ";
            Console.Clear();
            Console.Write(mainMenu);
            userChoice = int.Parse(Console.ReadLine());
            switch(userChoice)
            {
                case 1:
                    string activity1 = "Breathing Activity";
                    string text1 = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    Activity Message1 = new Activity(activity1, text1);
                    int duration1 = Message1.DisplayStartingMessage();
                    Console.WriteLine("Get Ready...");
                    Message1.ShowSpinner();
                    BreathingActivity breathingActivity = new BreathingActivity(activity1, text1, duration1);
                    breathingActivity.Run();
                    Message1.DisplayEndingMessage(duration1, activity1);
                    break;
                case 2:
                    string activity2 = "Listing Activity";
                    string text2 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    Activity Message2 = new Activity(activity2, text2);
                    int duration2 = Message2.DisplayStartingMessage();
                    Console.WriteLine("Get Ready...");
                    Message2.ShowSpinner();
                    ListingActivity listingActivity = new ListingActivity(activity2, text2, duration2);
                    listingActivity.Run();
                    Message2.DisplayEndingMessage(duration2, activity2);
                    break;
                case 3:
                    string activity3 = "Reflecting Activity";
                    string text3 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    Activity Message3 = new Activity(activity3, text3);
                    int duration3 = Message3.DisplayStartingMessage();
                    Console.WriteLine("Get Ready...");
                    Message3.ShowSpinner();
                    ReflectionActivity reflectionActivity = new ReflectionActivity(activity3, text3, duration3);
                    reflectionActivity.Run();
                    Message3.DisplayEndingMessage(duration3, activity3);
                    break;
                case 4:
                    break;
            }
        }
        
    }
}