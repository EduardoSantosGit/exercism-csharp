using System;
using System.Collections.Generic;
using System.Linq;

class House
    {

        public static string Rhyme()
        {
            Dictionary<int, string> _phrases = new Dictionary<int, string>
            {
                {0, "house that Jack built." },
                {1, "malt" },
                {2, "rat" },
                {3, "cat" },
                {4, "dog" },
                {5, "cow with the crumpled horn" },
                {6, "maiden all forlorn" },
                {7, "man all tattered and torn" },
                {8, "priest all shaven and shorn" },
                {9, "rooster that crowed in the morn" },
                {10, "farmer sowing his corn" },
                {11, "horse and the hound and the horn" }
            };
            Dictionary<int, string> _descriptor = new Dictionary<int, string>
            {
                {0, "lay in" },
                {1, "ate" },
                {2, "killed" },
                {3, "worried" },
                {4, "tossed" },
                {5, "milked" },
                {6, "kissed" },
                {7, "married" },
                {8, "woke" },
                {9, "kept" },
                {10, "belonged to" },
            };

            string str = "";
            /*for (int i = 0; i <= 11; i++)
            {
                Enumerable.Range(0,i).Where(x => x == 0).Select(x => str += "This is the " +  _phrases[i - x] + "\n");
                Enumerable.Range(0,i).Where(x => x != 0).Select(x => str += "that " + _descriptor[i - x] + " the " + _phrases[i - x] + "\n");
                str += "\n";
            }
            return new string( str.Where((x, i) => i < str.Length - 2).ToArray());*/
           
            for (int i = 0; i <= 11; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                        str += "This is the " + _phrases[i - j] + "\n";
                    else
                        str += "that " + _descriptor[i - j] + " the " + _phrases[i - j] + "\n";
                }
                str += "\n";
            }
            return new string( str.Where((x, i) => i < str.Length - 2).ToArray());
        }
    }