using System;
using System.Collections.Generic;
using System.Text;

namespace EasterTextAdventure.Scenes
{
    class InventoryScene : Scene
    {
        string art;
        string desc;
        int selectedItem;
        public InventoryScene(Game game) : base(game)
        {
            sceneArt = "";
            text = art + desc + "\n\n" + "select an item to view its description \n";
            myGame = game;

        }

        public override void Run()
        {



            //Scene.AddScene(this.GetType().Name);


            List<string> iterateOptions = new List<string>();




            foreach (Item element in myGame.myInventory.invGet())
            {
                iterateOptions.Add(element.getName());
            }
            iterateOptions.Add("Close Inventory");
            options = iterateOptions.ToArray();


            if (myGame.myInventory.invGet().Count == 0)
            {
                text = art + "\nThere is nothing in your inventory\n";
            }

            HelperFunctions.OptionsHelper opts_helper = new HelperFunctions.OptionsHelper(text, options);

            selectedItem = opts_helper.MenuChoice();

            //add this scene to the list of scenes


            if (selectedItem == iterateOptions.Count)
            {

                desc = "";

                sceneArt = "";
                text = art + desc;
            }

            else if (selectedItem > 0)
            {

                desc = myGame.myInventory.invGet()[selectedItem - 1].getDescription();
                text = art + desc + "\n\n" + "select an item to view its description \n";
                myGame.myInventoryScene.Run();
                selectedItem = 0;

            }
        }
    }
}