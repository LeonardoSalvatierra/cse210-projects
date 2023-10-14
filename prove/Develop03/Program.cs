using System;

class Program
{
    static void Main(string[] args)
    {
        string mainMenu = "Choose an option to memorize:\n1) 1 Nefi 3:7 \n2) Juan 3:5 \n3) D. y C. 19:23\n4) Isaías 1:18 \n5) Moroni 10: 4-5";
        Console.WriteLine(mainMenu);
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
                string words = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
                Scripture scripture1 = new Scripture(words);
                Reference reference1 = new Reference("1 Nefi", 3, 7);
                UserInterFace(scripture1, reference1);
                break;
            case 2:
                words = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";
                Scripture scripture2 = new Scripture(words);
                Reference reference2 = new Reference("Juan", 3, 5);
                UserInterFace(scripture2, reference2);
                break;
            case 3:
                words = "Learn of me, and listen to my words; walk in the meekness of my Spirit, and you shall have peace in me.";
                Scripture scripture3 = new Scripture(words);
                Reference reference3 = new Reference("D. y C", 19, 23);
                UserInterFace(scripture3, reference3);
                break;
            case 4:
                words = "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.";
                Scripture scripture4 = new Scripture(words);
                Reference reference4 = new Reference("Isaías", 1, 18);
                UserInterFace(scripture4, reference4);
                break;
            case 5:
                words = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\nAnd by the power of the Holy Ghost ye may know the truth of all things.";
                Scripture scripture5 = new Scripture(words);
                Reference reference5 = new Reference("Moroni", 10, 4, 10);
                UserInterFace(scripture5, reference5);
                break;
            
        }

    }
    static void UserInterFace(Scripture scripture, Reference reference)
    {
        string userChoice = "";
        while(userChoice.ToUpper() != "EXIT")
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide words or write EXIT to finish and quit the program");
            userChoice = Console.ReadLine();
            scripture.HideRandomWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}