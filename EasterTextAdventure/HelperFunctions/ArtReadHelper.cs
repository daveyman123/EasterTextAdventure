using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasterTextAdventure.HelperFunctions
{
    class ArtReadHelper
    {
        public static String ascii(string FileName)
        {

            string FileUrl = "Art/" + FileName + ".txt";

            string text = File.ReadAllText(FileUrl);
            return text;
        }
    }
}