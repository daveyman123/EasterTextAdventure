﻿using System;
using EasterTextAdventure.Scenes;
namespace EasterTextAdventure
{
    class Game
    {

        //inventory
        public Inventory myInventory;


        //title scene
        public Title myTitleScene;


        //main scene
        public RabbitStreet myRabbitStreetScene;

        // credits scene
        public Credits myCreditsScene;


        //game won
        protected bool gameWon;



        //play again field
        public static bool playAgain = true;
        public Game()
        {
            //instantiate the inventory
            myInventory = new Inventory();

            //instantiate the scenes
            myTitleScene = new Title(this);

           myRabbitStreetScene = new RabbitStreet(this);

            //goal of game 
            gameWon = false;

            //instantiate play again field
            playAgain = true;



        }

        public void Start()
        {


            myTitleScene.Run();

        }

        public void End()
        {
           // myCreditsScene.Run();


        }



        //get whether ghost is defeated
        public bool getGW()
        {
            return gameWon;
         }

    //set whether ghost is defeated
    public void setGWbool(bool gw)
    {
        this.gameWon = gw;
    }


    //set whether to play again
    public static void setplayAgain(bool pa)
    {
        playAgain = pa;
    }


    //get whether to play again, this is static so we can access and change it outside instantiated classes
    public static bool getPlayAgain()
    {
        return playAgain;
    }

    }
}