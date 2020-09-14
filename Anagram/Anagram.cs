using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            char[] word1array = word1.ToLower().ToCharArray();
            char[] word2array = word2.ToLower().ToCharArray();

            Array.Sort(word1array);
            Array.Sort(word2array);

            string word1sorted = new string(word1array);
            string word2sorted = new string(word2array);

            if (word1sorted == word2sorted)
                return true;
            else
                return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            for( int i = 0; i < candidates.Count; i++)
            {
                if(WordPairIsAnagram(word,candidates[i]) == false)
                {
                    candidates.Remove(candidates[i]);
                    i--;
                }
            }
            return candidates;
        }
    }
}
