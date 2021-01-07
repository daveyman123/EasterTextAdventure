using System;
using System.Collections.Generic;
using System.Text;
using EasterTextAdventure.HelperFunctions;

namespace EasterTextAdventure.Scenes
{
    class InventoryScene : Scene
    {
        string art;
        string desc;
        int selectedItem;
        public InventoryScene(Game game) : base(game)
        {
            sceneArt = Art.Art.inventory();
            text = sceneArt + desc + "\n\n" + "select an item to view its description \n";
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
                text = sceneArt + "\nThere is nothing in your inventory\n";
            }

            HelperFunctions.OptionsHelper opts_helper = new HelperFunctions.OptionsHelper(text, options);

            selectedItem = opts_helper.MenuChoice();

            //add this scene to the list of scenes


            if (selectedItem == iterateOptions.Count)
            {

                desc = "\nselect an item to view its description \n";


                sceneArt = Art.Art.inventory();
                text = sceneArt + desc;
            }

            else if (selectedItem > 0)
            {

                desc = myGame.myInventory.invGet()[selectedItem - 1].getDescription();
                text = sceneArt + desc + "\n\n" + "select an item to view its description \n";
                myGame.myInventoryScene.Run();
                selectedItem = 0;

            }
        }
    }
}