﻿using System;
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
        public static string Tortoise()
        {
            return ArtReadHelper.ascii("tortoise");
        }
        public static string Title()
        {
            return ArtReadHelper.ascii("title");
        }
        public static string Bunny2() {
            return ArtReadHelper.ascii("bunny2");
                }
        public static string inventory()
        {
            return ArtReadHelper.ascii("inventory");
        }
    }
}
