using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?

            twitchStream.name = "De vader van m'n vriend femke is streamer, en ik wil heel graag fortnite met hem spelen, dus om te slijmen kies ik hem";
            twitchStream.lastStreamName = "fortnite season 2 (epic)";
            twitchStream.streamGame = new Game("Pikmin 4");
            twitchStream.followers = 6;
            twitchStream.automod = false;


            Console.WriteLine("Hello, World!");
        }
    }
}