using System;
using System.Collections.Generic;
using System.Text;
using EasterTextAdventure.Art;
using EasterTextAdventure.HelperFunctions;
namespace EasterTextAdventure.Scenes
{
    class RabbitStreet : Scene
    {
       string RSsceneArt = Art.Art.Bunny();
       string RSaddText = "You are at Rabbit Street. Vinnie looks busy";
       string[] RSoptions = new String[] { "Talk to vinnie", "Go to the Giovanni's Garden", "View INVENTORY","Exit Game" };


    public RabbitStreet (Game game) : base(game)
        {
            sceneArt = RSsceneArt;
            addText = RSaddText;
            options = RSoptions;
        }

        public override void Run()
        {
          
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    //talk to vinnie

                    //vinnies options
                    addText = "Welcome to Rabbit Street Kid";
                    sceneArt = Art.Art.Bunny2();
                    options = new String[] { "Whats Rabbit Street?", "How do I become the king of Rabbit Street?", "Who is currently the king of Rabbit Street?" };
                    base.Run();
                    switch (optionsChoice)
                    {
                        case 1:
                            //addText = "Rabbit street is the place where all your dreams can come true kid, or NOT! Collect enough carrots and you dont gotta worry bout nothing. and thats the truth!";
                            addText = "as survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum";
                            options = new String[] { "OK" };
                            base.Run();
                        
                            addText = "You kids never understand. let me get back to sorting, or Giovanni's gonna whip my ass!";

                            options = new string[] { "OK"};

                            


                            
                            base.Run();

                            //set everything back to the way it was at the beginning of mainstreet scene
                            sceneArt = RSsceneArt;
                            addText = RSaddText;
                            options = RSoptions;
                            myGame.myRabbitStreetScene.Run();
                            return;
                            
                    }
                
              

                    
                    return;
                case 2:
                    base.Run();
                    return;
                case 3:
                    myGame.myInventoryScene.Run();
                    myGame.myRabbitStreetScene.Run();
                    return;
                case 4:
                    
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myRabbitStreetScene.Run(); }
                    return;

            }
        }
    }
}
