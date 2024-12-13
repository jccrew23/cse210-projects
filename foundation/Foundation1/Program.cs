using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video firstVid = new Video();

        firstVid._title = "Christmas Guitar - Christmas Hymns and Carols - 5 hours of Instrumental Music - Josh Snodgrass";
        firstVid._author = "Josh Snodgrass";
        firstVid._length = 500;

        Comment firstVidfirstCom = new Comment();
        firstVidfirstCom._commenter = "jason165";
        firstVidfirstCom._commentText = "So soothing. Helps me get in the Christmas mood!";
        firstVid._vidComments.Add(firstVidfirstCom);

        Comment firstVidsecCom = new Comment();
        firstVidsecCom._commenter = "benIsAwesome";
        firstVidsecCom._commentText = "So great for a calming study section during the holiday season";
        firstVid._vidComments.Add(firstVidsecCom);

        Comment firstVidthirdCom = new Comment();
        firstVidthirdCom._commenter = "BruderUderBoy";
        firstVidthirdCom._commentText = "Merry music for a merry season";
        firstVid._vidComments.Add(firstVidthirdCom);    

        Video secondVid = new Video();

        secondVid._title = "PENTATONIX + HOME FREE| Christmas Songs Collection";
        secondVid._author = "JadzTV";
        secondVid._length = 1200;

        Comment secVidfirstCom = new Comment();
        secVidfirstCom._commenter = "tSwizzleDizzle";
        secVidfirstCom._commentText = "Pentatonix is my favorite. Love the A Capella!";
        secondVid._vidComments.Add(secVidfirstCom);

        Comment secVidsecCom = new Comment();
        secVidsecCom._commenter = "grumpyStiltskin";
        secVidsecCom._commentText = "They sounded better in their earlier music.";
        secondVid._vidComments.Add(secVidsecCom);

        Comment secVidthirdCom = new Comment();
        secVidthirdCom._commenter = "LaughingLyric";
        secVidthirdCom._commentText = "Mary did you Know is a cult classic!";
        secondVid._vidComments.Add(secVidthirdCom);

        Video thirdVid = new Video();

        thirdVid._title = "Top 50 Most Legendary Christmas Songs of All Time!❄️☃️ Best Songs To Get Into The Christmas Spirit ?";
        thirdVid._author = "Christmas Sounds";
        thirdVid._length = 460;

        Comment thirdVidfirstCom = new Comment();
        secVidfirstCom._commenter = "ThisleBloom";
        secVidfirstCom._commentText = "I don't know that these are legendary but they worked for my party.";
        thirdVid._vidComments.Add(secVidfirstCom);

        Comment thirdVidsecCom = new Comment();
        thirdVidsecCom._commenter = "NetflixandSkill";
        thirdVidsecCom._commentText = "So beatiful!";
        thirdVid._vidComments.Add(thirdVidsecCom);

        Comment thirdVidthirdCom = new Comment();
        thirdVidthirdCom._commenter = "404BrainNotFound";
        thirdVidthirdCom._commentText = "Merry Christmas";
        thirdVid._vidComments.Add(thirdVidthirdCom);

        Video fourthVid = new Video();

        fourthVid._title = "Sweet Christmas Jazz 🎄 Smooth Jazz Instrumental Music & Christmas Bossa Nova Piano to Greats Holiday";
        fourthVid._author = "Sweet Morning Cafe";
        fourthVid._length = 5400;

        Comment fourthVidfirstCom = new Comment();
        fourthVidfirstCom._commenter = "GuacandRoll";
        fourthVidfirstCom._commentText = "God Bless You and Your family";
        fourthVid._vidComments.Add(fourthVidfirstCom);

        Comment fourthVidsecCom = new Comment();
        fourthVidsecCom._commenter = "CharlieBitMe27";
        fourthVidsecCom._commentText = "Such a great mix of fun and soft!";
        fourthVid._vidComments.Add(fourthVidsecCom);

        Comment fourthVidthirdCom = new Comment();
        fourthVidthirdCom._commenter = "404BrainNotFound";
        fourthVidthirdCom._commentText = "Merry Christmas";
        fourthVid._vidComments.Add(fourthVidthirdCom);

        videos.Add(firstVid);
        videos.Add(secondVid);
        videos.Add(thirdVid);
        videos.Add(fourthVid);

        foreach (Video vids in videos) {
            int numComments = vids.NumberComments();
            Console.WriteLine($"{vids._title} published by {vids._author}\nDuration: {vids._length} seconds");
            Console.WriteLine($"There are {numComments} comments.");
            vids.DisplayComments();
            Console.WriteLine("");
        }



        
    }
}