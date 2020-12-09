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
            string text ="";
            string FileUrl = "Art/" + FileName + ".txt";
            var lineCount = File.ReadAllLines(FileUrl).Length;
            text += "``````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````";
            System.Collections.Generic.IEnumerable<String> lines = File.ReadLines(FileUrl);
            int longestCount = 0;
            
            foreach(string line in lines)
            {
                
                if (line.Length > longestCount)
                {
                    longestCount = line.Length;
                }
                
               
            }
            longestCount = 65 - longestCount/2;
            foreach(string line in lines)
            {
                string newLines = "";
                int x = 0;
                newLines += "|";
                while (x < longestCount)
                {
                    newLines += " ";
                    x += 1;
                }
                
                text +="\n" + newLines + line;
            }
            //text += File.ReadAllText(FileUrl);
            while (lineCount < 17)
            {
                text += "\n";
                lineCount += 1;
            }
            text += "``````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````";
            return text;
        }
        public static string write(string sentence)
        {
            string sentence_updated = "";
            if (!String.IsNullOrEmpty(sentence) && sentence != " ")
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    int x = i % 110;
                    if (x == 0 && i != 0)
                    {
                        int h = 1;
                        int z = i;
                        while (h < 15)
                        {

                            sentence_updated += sentence[z];
                            if (sentence[z].ToString() == (" "))
                            {
                                sentence_updated +="\n";
                                break;
                            }

                            z += 1;
                            h += 1; ;

                        }
                        i = z;

                    }
                    else
                    {
                        sentence_updated += sentence[i];
                    }
                }
                return sentence_updated;
            }
            return "";
        }
    }

}