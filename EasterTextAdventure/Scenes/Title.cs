using System;
using System.Collections.Generic;
using System.Text;
using EasterTextAdventure.Art;
using EasterTextAdventure.HelperFunctions;

namespace EasterTextAdventure.Scenes
{
    class Title : Scene
    {

        public Title (Game game) : base(game)
        {
            sceneArt = Art.Art.Title();
            text = "Welcome to the game\n\n" +
                sceneArt;
            options = new String[] { "Play", "Credits", "Exit Game" };
         
        }

        public override void Run()
        {
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    myGame.myRabbitStreetScene.Run();
                    return;
                case 2:
                    myGame.myCreditsScene.Run();
                    return;
                case 3:
                    
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myCreditsScene.Run(); }
                    return;

            }
        }
    }
}
