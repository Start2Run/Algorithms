// ==========================================================================
// <copyright file="StringReductionHelper.cs" company="Genetec">
//   Copyright (c) 2018 by Genetec
//   All rights reserved. May be used only in accordance with a valid Source Code License Agreement.
// </copyright>
// Created: 01/03/2021
// Last update: 01/03/2021
// ==========================================================================

namespace StringReduction
{
    using System.Linq;

    public class StringReductionHelper
    {
        private static char[] _characters = new[] { 'a', 'b', 'c' };
        // Complete the stringReduction function below.
        public int StringReduction(string s)
        {
            var occurence = true;
            while (occurence && s.Length != 1)
            {
                occurence = false;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        continue;
                    }

                    occurence = true;
                    if (_characters.Any(character => ReplaceSubstring(ref s, i, character)))
                    {
                        i--;
                        //break;
                    }
                }
            }

            return s.Length;
        }

        private static bool ReplaceSubstring(ref string s, int position, char character)
        {
            var result = s[position] != character && s[position + 1] != character;
            if (result)
            {
                s = s.Remove(position, 2);
                s = s.Insert(position, character.ToString());
            }

            return result;
        }
    }
}
