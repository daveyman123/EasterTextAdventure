using System;
using System.Collections.Generic;
using static System.Console;
using EasterTextAdventure.HelperFunctions; 
namespace EasterTextAdventure
{
    class Program
    {
        static void Main(string[] args)
    {
        try
        {
            WindowWidth = 130;
            WindowHeight = 35;
        }
        catch
        {
            Console.WriteLine("Cannot create a big enough console window");
            Console.WriteLine("Try adjusting your font/console settings and restarting.");
            Console.WriteLine("You can continue playing, just be aware that some art might not render properly!");
            Console.ReadLine();
        }

     
        ForegroundColor = ConsoleColor.DarkYellow;

        //try to start game
      
            Game myGame = new Game();
            myGame.Start();
        
       // ConsoleUtils.QuitConsole();
    }
}
}