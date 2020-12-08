using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace EasterTextAdventure.HelperFunctions
{ 
   class OptionsHelper

{
        
    int selectedIndex;
    String[] opt = new String[] { "Go to the North Pole(GO HERE FIRST)", "Go to Main Street", "View INVENTORY", "Exit Game" };
    string prompt = "";


    public OptionsHelper(string prompt)
    {
        this.prompt = prompt;


    }
    public OptionsHelper(string[] opt)
    {
        this.opt = opt;


    }
    public OptionsHelper(string prompt, String[] opt)
    {
        this.opt = opt;
        this.prompt = prompt;
        //add inventory option to options

    }

    public void DisplayOptions()
    {

            int optionsHalfScreen = 50;
            int promptHelpHalfScreen = 33;

            string output2 = "";

            string output = "";

       
            output2 += "Use the arrow keys to select your choice and press enter";
            // output2 += "\nYour options are:\n";
            Console.WriteLine(prompt);
            Console.SetCursorPosition(promptHelpHalfScreen, 23);
            Console.WriteLine(output2);
            Console.SetCursorPosition(promptHelpHalfScreen, 24);
            Console.WriteLine("`````````````````````````````````````````````````````````");
           
            string prefix;
        for (int i = 0; i < opt.Length; i++)
        {
            string currentOption = opt[i];


            if (i == selectedIndex)
            {
                prefix = "*";
                    Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition(optionsHalfScreen, 25 + i);
                    Console.WriteLine(prefix + currentOption);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            else
            {
                prefix = " ";
                    Console.SetCursorPosition(optionsHalfScreen, 25 + i);
                    Console.WriteLine(prefix + currentOption);
                }
                
               

        }
           
           










    }
    public int MenuChoice()
    {
        ConsoleKey keyPressed;
        do
        {
            Clear();

            DisplayOptions();
            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {

                selectedIndex--;
                if (selectedIndex == -1)
                {
                    selectedIndex = opt.Length - 1;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                selectedIndex++;
                if (selectedIndex == opt.Length)
                {
                    selectedIndex = 0;
                }
            }
        } while (keyPressed != ConsoleKey.Enter);
        return selectedIndex + 1;
    }

}
}

