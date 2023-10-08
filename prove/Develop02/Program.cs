using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to your Journal!");
        PromptGenerator prompts = new PromptGenerator();
        Journal texts = new Journal();
        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("what would you like to do?: ");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
            case 1:
                Entry newEntry = new Entry();
                

                newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");
                newEntry._prompt = prompts.GetPrompt();
                Console.WriteLine($"{newEntry._prompt}");
                newEntry._response = Console.ReadLine();
                texts._entries.Add(newEntry);
                break;
            
        
            case 2:
            Console.WriteLine();
            texts.Displaytexts();
            break;
        
            case 3:
            Console.WriteLine();
            Console.WriteLine("What is the filename?: ");
            string file = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("-");
                string date = parts[0];
                string prompt = parts[1];
                string answer = parts[2];
            }
            
            break;

            case 4:
            Console.WriteLine("What is the filename?: ");
            file = Console.ReadLine();
            Console.WriteLine("saving...");
            using (StreamWriter outputFile = new StreamWriter(file))
            {
    
                foreach (Entry entry in texts._entries)
                {
                    outputFile.WriteLine($"Date: {entry._date} - {entry._prompt} - {entry._response}");
                }     
            };
            Console.WriteLine("Saved!");          
            break;
            }    

        }
    }

}