using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("Bink's Sake (Piano Tutorial Lesson)", "Amosdoll Music", 150);
        _videos[0].AddComment("Rimanella", "You played so beautifully, it made my skin shiver.");
        _videos[0].AddComment("SamGamer", "what a good tutorial man");
        _videos[0].AddComment("Kasssadinx", "I've never played piano  before but I'm determined to learn this song");

        _videos[1] = new Video("Microsoft Excel Tutorial - Beginners Level 1", "Teacher's Tech", 980);
        _videos[1].AddComment("NunoMartins", "5 years later and this is still useful.");
        _videos[1].AddComment("Gaming", "Great tutorial! Excited about the remaining ones to come!");
        _videos[1].AddComment("notaPro", "Very easy to understand bruh");
        
        _videos[2] = new Video("ONE PIECE | Official Trailer | Netflix", "Netflix", 750);
        _videos[2].AddComment("Aloo4346", "Honestly looks great");
        _videos[2].AddComment("Duke", "It is amazing to watch them be so faithful to the source material");
        _videos[2].AddComment("doom_owo", "You made the impossible, possible. Thank you Netflix");

        _videos[3] = new Video("Making an OPEN WORLD for my INDIE GAME - Resttore Devlog #1", "SΛBISHII", 480);
        _videos[3].AddComment("Eren Kaya", "Great work. Can I know how much time it took to create this scene in total?");
        _videos[3].AddComment("Gili Gili chu", "Sir which pc you used unity or unreal engine 5?????????");
        _videos[3].AddComment("nDaveydawn", "i like this result");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}