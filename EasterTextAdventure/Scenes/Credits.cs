using System;
using System.Collections.Generic;
using System.Text;
using EasterTextAdventure.Art;
using EasterTextAdventure.HelperFunctions;
namespace EasterTextAdventure.Scenes
{
    class Credits : Scene
    {

        public Credits (Game game) : base(game)
        {
            sceneArt = Art.Art.Title();
            text = "Thanks for playing the game\n\n" +
                "\nArt for game:" +
                "\nhttps://asciiart.website";
            options = new String[] { "Exit", "Back to Title Menu" };
         
        }

        public override void Run()
        {
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myCreditsScene.Run(); }
                    return;
                case 2:
                    myGame.myTitleScene.Run();
                    return;
            }
        }
    }
}
