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
       string RSaddText = "You are at Rabbit Street. Vinnie, the rabbit, looks busy.";
       string[] RSoptions = new String[] { "Talk to Vinnie the rabbit", "Giovanni's Garden", "Go to the tortoises house", "Inventory","Exit Game" };


    public RabbitStreet (Game game) : base(game)
        {
            Initialize(RSsceneArt,RSaddText,RSoptions);
        }
        private void Initialize(
              string RSsceneArt, string RSaddText, string[] RSoptions)
        {
            sceneArt = RSsceneArt;
            addText = RSaddText;
            options = RSoptions;
        }
        //resets the original variables to when the class was initialized
        private void Reset()

        {
            Initialize(RSsceneArt, RSaddText, RSoptions);
        }

        //talk to vinnie initial part
        private void TalkVinnie()
        {
            addText = "Welcome to Rabbit Street Kid, Wadda ya want? wadda wadda-wad da ya wan? get it? I am the King of rabbit streety street!";
            sceneArt = Art.Art.Bunny2();
            options = new String[] { "Whats Rabbit Street?", "How do I become the king of Rabbit Street?", "Who is actually the king of Rabbit Street?", "Leave Vinnie Alone" };

        }
        public override void Run()
        {
          
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    //talk to vinnie
                    TalkVinnie();


                    //vinnies options


                    talkingVinnieSwitch();
                    
                    return;
                case 2:

                    //go to Giovannis Garden
                    myGame.myFinishLineScene.Run();

                    return;
                case 3:
                    myGame.myTortoiseScene.Run();
                    return;
                case 4:
                    myGame.myInventoryScene.Run();
                    myGame.myRabbitStreetScene.Run();
                    return;
                case 5:
                    
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myRabbitStreetScene.Run(); }
                    return;

            }
        }
        public void talkingVinnieSwitch()
        {
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    //addText = "Rabbit street is the place where all your dreams can come true kid, or NOT! Collect enough carrots and you dont gotta worry bout nothing. and thats the truth!";
                    addText = "Rabbit Street is the place of hopes and dreams or dreams of hopes, ya'see? Become King of rabbit street and you can get all the carrots. wooo woo im zaney vinnie. yup ZANEY vinnie the rabbit, thats what they call me!";
                    options = new String[] { "OK" };
                    base.Run();

                    addText = "You kids never understand. let me get back to sorting, or Giovanni's gonna whip my ass!";

                    options = new string[] { "OK, just one more question though.", "I'll let you get back to whatever you were doing." };
                    base.Run();
                    switch (optionsChoice)
                    {
                        case 1:
                            TalkVinnie();
                           
                            talkingVinnieSwitch();
                            break;
                        case 2:
                            Reset();
                            myGame.myRabbitStreetScene.Run();
                            break;
                    }







                    myGame.myRabbitStreetScene.Run();

                    return;
                case 2:
                    addText = "You wouldnt believe the things Giovanni put us through in order that he could earn his precious title of 'King' of Rabbit Street. But why are you asking me? Everyone knows I'm not a good source of info. Thats why they call me stupid vinney.";
                    options = new string[] { "Ok Vinnie, I understand you must have seen a lot" };


                    myGame.myRabbitStreetScene.Run();

                    return;
                case 3:
                    addText = "Giovanni is for now kid. woo woo zippidy doo da. long live the king.";
                    options = new string[] { "Why is Giovanni king?", "Leave Vinnie alone" };
                    base.Run();
                    switch (optionsChoice)
                    {
                        case 1:
                            addText = "Giovanni killed all the rival rabbit gang members. least thats what i hear. but I dont hear to good ya'hear?";
                            options = new string[] { "Leave Vinnie alone" };
                            base.Run();



                            addText = "alright kid i like you a little and i will be there to help you out.";
                            options = new string[] { "Ok, whatever, Vinnie" };
                            base.Run();
                            Reset();
                            myGame.myRabbitStreetScene.Run();

                            return;
                        case 2:
                            addText = "alright kid i like you a little and i will be there to help you out.";
                            options = new string[] { "Ok, whatever, Vinnie" };
                            base.Run();
                            Reset();
                            myGame.myRabbitStreetScene.Run();
                            return;
                    }
                    return;
                case 4:
                    Reset();
                    myGame.myRabbitStreetScene.Run();
                    return;

            }




            return;
        }

    }
}
