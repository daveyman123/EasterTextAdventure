using System;
using System.Collections.Generic;
using System.Text;
using EasterTextAdventure.Art;
using EasterTextAdventure.HelperFunctions;

namespace EasterTextAdventure.Scenes
{
    class Tortoise : Scene
    {
        Item Jacket;
        Items TortItems;
        public Tortoise (Game game) : base(game)
        {

            Jacket = new Item("Jacket", "A cool looking jacket that will keep you warm");
            TortItems = new Items(Jacket);
            sceneArt = Art.Art.Tortoise();
            addText = "Hi my names Thomas, so very nice to meet you\n" +
                "There are some items here: " + TortItems.returnItem(Jacket.getName()).getName() ;
            options = new String[] { "Talk to Thomas","Take Item", "Leave the tortoises house", "Exit Game" };
         
        }

        public override void Run()
        {
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    addText = "So very good to talk with you. dont mind that rabbit he is always in a hurry for no good reason. plus he doesnt know how to keep warm like I do!";
                    myGame.myTortoiseScene.Run();
                    return;
                case 2:
                    
                    addText += "\n" + myGame.myInventory.invAdd(Jacket);
                    TortItems.RemoveItem(Jacket);
                    myGame.myTortoiseScene.Run();
                    return;
                case 3:
                    myGame.myRabbitStreetScene.Run();
                    return;
                case 4:
                    
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myCreditsScene.Run(); }
                    return;

            }
        }
    }
}
