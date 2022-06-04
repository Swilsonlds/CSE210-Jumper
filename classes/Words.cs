using System;
using System.Collections.Generic;
using System.IO;

namespace CSE210_Jumper.classes
{
    public class Words
    {
        public List<string> WordsList= new List<string>();

        public string GetWord()
        {
            Random random = new Random();
            int listIndex = random.Next(11);
            return WordsList[listIndex];
        }

        public void PopulateList()
        {
            WordsList.Add("hello");
            WordsList.Add("robot");
            WordsList.Add("computer");
            WordsList.Add("elephant");
            WordsList.Add("laughing");
            WordsList.Add("zebra");
            WordsList.Add("final");
            WordsList.Add("reduce");
            WordsList.Add("ninja");
            WordsList.Add("echo");
        }
    }
}
