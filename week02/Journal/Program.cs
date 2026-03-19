// Creative Enhancements
// 1. Added a few of my own prompts
// 2. Added a third class: UserSelection.cs
// 3. Added a way for the user to add additional comments in addition to the random prompt
// 4. By default the working directory on my computer is several levels below the source code 
//    directory. I added code to store the user's journal in the same directory as the
//    source code.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal.ShowMenu();
    }
}
