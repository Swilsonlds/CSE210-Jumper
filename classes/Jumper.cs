using System;
using System.Collections.Generic;
using System.IO;

namespace CSE210_Jumper.classes
{
    public class Jumper
    {
        List<string> jumper = new List<string>();

        public void DisplayJumper(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine(" ___");
                Console.WriteLine("/___\\");
                Console.WriteLine("\\   /");
                Console.WriteLine(" \\ /");
                Console.WriteLine("  0  ");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\ ");
            }

            else if (wrong == 1)
            {
                Console.WriteLine("/___\\");
                Console.WriteLine("\\   /");
                Console.WriteLine(" \\ /");
                Console.WriteLine("  0  ");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\ ");
            }

            else if (wrong == 2)
            {
                Console.WriteLine("\\   /");
                Console.WriteLine(" \\ /");
                Console.WriteLine("  0  ");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\ ");
            }

            else if (wrong == 3)
            {
                Console.WriteLine(" \\ /");
                Console.WriteLine("  0  ");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\ ");
            }

            else if (wrong == 4)
            {
                Console.WriteLine("  X  ");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\ ");
            }



        }
      
    }
}
