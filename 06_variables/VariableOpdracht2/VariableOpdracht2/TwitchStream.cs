using System;

namespace VariableOpdracht2
{
    internal class TwitchStream
    {
        /*
        - maak hier class variables aan
        - Zet overal internal voor
        -  LET OP, geef hier geen waardes. dus alleen : 
            > internal int mijnVariable;
        */

        //maak deze variabelen aan:
        // type=string, naam: name,
        // type=string, naam: lastStreamName
        // type=Game, naam: streamGame
        // type=int, naam: followers
        // type=bool, naam: automod

        internal string name;
        internal string lastStreamName;
        internal Game streamGame;
        internal int followers;
        internal bool automod;

    }
}