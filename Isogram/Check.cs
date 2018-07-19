using System;
using System.Collections.Generic;

namespace Isogram
{
    public class Check
    {
        public bool CheckIsogram(string val)
        {
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            foreach (char c in val)
            {
                if (char.IsWhiteSpace(c))
                {
                    charMap = new Dictionary<char, int>();
                }
                else if (char.IsLetter(c))
                {
                    if (charMap.ContainsKey(c))
                    {
                        return false;
                    }
                    charMap.Add(c, 1);
                }
            }
            return true;
        }
    }
}
