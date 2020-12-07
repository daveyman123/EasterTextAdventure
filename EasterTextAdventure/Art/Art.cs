using System;
using System.Collections.Generic;
using System.Text;
using EasterTextAdventure.HelperFunctions;
namespace EasterTextAdventure.Art
{
    public static class Art
    {
        public static string Bunny() 
        {
            return ArtReadHelper.ascii("bunny");
        }
        public static string Title()
        {
            return @"

                                               
                                               Easter Game 
                                               
                  _             _____              _     _    _____            __  __  
                 | |           |  __ \            (_)   | |  / ____|          / _|/ _| 
                 | |__  _   _  | |  | | __ ___   ___  __| | | |  __ _ __ __ _| |_| |_  
                 | '_ \| | | | | |  | |/ _` \ \ / / |/ _` | | | |_ | '__/ _` |  _|  _| 
                 | |_) | |_| | | |__| | (_| |\ V /| | (_| | | |__| | | | (_| | | | |   
                 |_.__/ \__, | |_____/ \__,_| \_/ |_|\__,_|  \_____|_|  \__,_|_| |_|   
                         __/ |                                                         
                        |___/ 

";
        }
        public static string Bunny2() {
            return ArtReadHelper.ascii("bunny2");
                }
    }
}
