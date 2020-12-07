using System;
using System.Collections.Generic;
using System.Text;
using EasterTextAdventure.Art;
using EasterTextAdventure.HelperFunctions;
namespace EasterTextAdventure.Scenes
{
    class RabbitStreet : Scene
    {

        public RabbitStreet (Game game) : base(game)
        {
            sceneArt = Art.Art.Bunny();
            text = "Welcome to the game.";
            options = new String[] { "Talk to vinnie", "Go to the Giovanni's Garden", "Exit Game" };
         
        }

        public override void Run()
        {
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    //talk to vinnie
                    text = "hey kid";
                    sceneArt = Art.Art.Bunny2();
                    base.Run();
                    return;
                case 2:
                    base.Run();
                    return;
                case 3:
                    
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myCreditsScene.Run(); }
                    return;

            }
        }
    }
}
