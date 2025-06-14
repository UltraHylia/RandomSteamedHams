List<String> chalmersLines = ["Well Seymour, I made it. Despite your directions.", "Myegh", "Agh-!", "SEEEEEEYMOOOOOUR!", "Why is there smoke coming out of your oven, Seymour?",
    "I thought we were having steamed clams?", "You call hamburgers steamed hams?", "Uh-huh. Eh, what region?",
    "Really? Well, I'm from Utica, and I've never heard anyone use the phrase 'steamed hams'", "Ah, I see.",
    "You know, these hamburgers are quite similar to the ones they have at Krusty Burger", "...for steamed hams?",
    "Yes, and you call them steamed hams, despite the fact they are obviously grilled", "Of course", "Yes, I should be- good lord, what is happening in there?!",
    "Agh- Aurora Borealis?!", "At this time of year?!", "At this time of day?!", "In this part of the country?!", "Localised entirely within your kitchen?!", "May I see it?",
    "Well, Seymour, you are an odd fellow. But I must say, you steam a good ham."];

List<String> skinnerLines = ["Ah Superintendent Chalmers, welcome! I hope you're prepared for an unforgettable luncheon!", "Oh egads! My roast is ruined!",
    "But what if... I were to purchase fast food and disguise it as my own cooking?", "Hohoho! Delightfully devilish, Seymour!",
    "Superintendent, I was just- uh, just stretching my calves on the windowsill! Isometric exercise! Care to join me?",
    "Uhh... oh, that isn't smoke! It's steam. Steam from the steamed clams we're having! Mmm, steamed clams!", "Phew!",
    "Superintendent, I hope you're ready for mouthwatering hamburgers!", "Oh, no, I said steamed hams! That's what I call hamburgers.",
    "Yes! It's a regional dialect.", "Uh... Upstate New York?", "Oh not in Utica, no! It's an Albany expression.", "Hohoho, no! Patented Skinner Burgers! Old family recipe!",
    "Yes!", "Ye- uh... you know... one thing I should... excuse me for one second.", "Ahh, well, that was wonderful! Good time was had by all, I'm pooped.",
    "Aurora Borealis", "Yes!", "...no.", "No, Mother, it's just the Northern Lights!"];

List<String> motherLines = ["Seymour! The house is on fire!", "HELP! HELP!"];

List<String> songLines = ["Skinner with his crazy explanations", "The Superintendent's gonna need his medication", "When he hears Skinner's lame exaggerations",
    "There'll be trouble in town tonight!"];

int[] speaker = [0, 1, 0, 1, 1, 1, 0, 2, 2, 2, 2, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 3, 1, 0, 3];

int totalLines = chalmersLines.Count() + skinnerLines.Count() +  motherLines.Count() + songLines.Count();

int chalmersCount = 0;
int skinnerCount = 0;
int songCount = 0;
int motherCount = 0;

bool chalmersRandom = true;
bool skinnerRandom = true;
bool motherRandom = true;
bool songRandom = true;

Random rnd = new Random();

for (int i = 0; i <= totalLines - 1; i++)
{

    if (speaker[i] == 0) {
        if (chalmersRandom)
        {
            writeRandomLine(0);
        }

        else if (!chalmersRandom)
        {
            Console.WriteLine("Chalmers: " + chalmersLines[i]);
            chalmersCount++;
        }
    }

    else if (speaker[i] == 1)
    {
        if (skinnerRandom)
        {
            writeRandomLine(1);
        }

        else if (!skinnerRandom)
        {
            Console.WriteLine("Skinner: " + skinnerLines[skinnerCount]);
            skinnerCount++;
        }
    }

    else if (speaker[i] == 2)
    {

        if (songRandom)
        {
            writeRandomLine(2);
        }

        else if (!songRandom)
        {
            Console.WriteLine("Theme song: " + songLines[songCount]);
            songCount++;
        }

    }

    else if (speaker[i] == 3)
    {
        
        if (motherRandom)
        {
            writeRandomLine(3);
        }

        else if (!motherRandom)
        {
            Console.WriteLine("Mother: " + motherLines[motherCount]);
            motherCount++;
        }
    }

    else
    {
        error();
    }
}

void writeRandomLine(int character)
{
    if (character == 0)
    {
        int line = rnd.Next(0, chalmersLines.Count());
        Console.WriteLine("Chalmers: " + chalmersLines[line]);
        chalmersLines.RemoveAt(line);
    }

    else if (character == 1)
    {
        int line = rnd.Next(0, skinnerLines.Count());
        Console.WriteLine("Skinner: " + skinnerLines[line]);
        skinnerLines.RemoveAt(line);
    }

    else if (character == 2)
    {
        int line = rnd.Next(0, songLines.Count());
        Console.WriteLine("Theme song: " + songLines[line]);
        songLines.RemoveAt(line);
    }

    else if (character == 3)
    {
        int line = rnd.Next(0, motherLines.Count());
        Console.WriteLine("Mother: " + motherLines[line]);
        motherLines.RemoveAt(line);
    }

    else
    {
        error();
    }

}

void error()
{
    Console.WriteLine("Something has gone horribly wrong and Hylia needs to fix her code.");
}