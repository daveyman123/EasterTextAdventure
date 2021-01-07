using System;
using System.Collections.Generic;
using System.Text;

namespace EasterTextAdventure.Scenes
{
    class FinishLine : Scene
    {
        public FinishLine(Game game) : base(game)
        {
            sceneArt = HelperFunctions.ArtReadHelper.ascii("flag");
            text = "welcome to the finishline";
        }

        public override void Run()
        {
            addText = text;
            options = new string[] { "blah", "blah", "blah" };
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    return;



            }



        } 
    }
}
