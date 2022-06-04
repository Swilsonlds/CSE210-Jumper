using System;
using System.Collections.Generic;
using System.IO;

namespace CSE210_Jumper.classes
{
    public class Director
    {
        private bool isPlaying = true;
        Player player = new Player();
        Words words = new Words();
        Jumper jumper = new Jumper();

        string word = "";

        List<string> wordAsList = new List<string>();

        List<string> emptyList = new List<string>();

        List<string> guessList = new List<string>();

        

        public void StartGame()
        {
            player.numOfGuesses = 0;
            words.PopulateList();
            word = words.GetWord();
            foreach (char c in word)
            {
                wordAsList.Add(c.ToString());
            }

             foreach (char c in word)
            {
                emptyList.Add("_ ");
            }

        

            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
            }
            
            foreach(string i in wordAsList)   
            {
                if (guessList.Contains(i))
                {
                    Console.Write(i + " ");
                }

                else
                {
                    Console.Write("_ ");
                }
            }

            Console.WriteLine("\n\n");


            Console.WriteLine("  X  ");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" / \\ ");
            Console.WriteLine(" ");
            Console.WriteLine("Game over. Better luck next time!");
        }

        public void GetInputs()
        {
            foreach(string i in wordAsList)   
            {
                if (guessList.Contains(i))
                {
                    Console.Write(i + " ");
                }

                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine("\n\n ");
            jumper.DisplayJumper(player.numOfGuesses);
            Console.WriteLine("");

            Console.Write("Guess a letter [a-z]: ");
            player.guess = Console.ReadLine();
            Console.WriteLine(" ");

            guessList.Add(player.guess);
        }

        public void DoUpdates()
        {
            if (wordAsList.Contains(player.guess))
            {
                player.numOfGuesses = player.numOfGuesses;
            }

            else
            {
                player.numOfGuesses += 1;
            }

            

            if (player.numOfGuesses > 3)
            {
                isPlaying = false;
            }

            else
            {
                isPlaying = true;
            }

        
        }

    }
}
