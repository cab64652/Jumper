using System;
using System.Collections.Generic;
using System.Linq;

namespace Jumper
{
    public class Word
    {
        // These are the attributes
        // private List<string> _secret = new List<string>() {"b","a","n","a","n","a"};
        // private List<string> _guesses = new List<string>() { "_", "_", "_", "_", "_", "_"};

        private List<string> _secret = new List<string>();
        private List<string> _guesses = new List<string>();

        // This is the constructor.
        public Word()
        {
            List<string> words = new List<string>() { "banana", "apple", "orange"};
            Random random = new Random();
            int index = random.Next(words.Count);
            string word = words[index];
            string[] letters = word.ToCharArray().Select(c => c.ToString()).ToArray();
            _secret = new List<string>(letters);
            // _secret = new List<string>(word.Split(""));

            // use a loop to set _guesses to a list of underscores (the same number of letters in _secret)
        
            for (int i = 0; i < _secret.Count; i++)
            {
                _guesses.Add("_");
            }
        
        }

        // These are the methods
        public void CheckGuess(string guess)
        {
            for (int i = 0; i < _secret.Count; i++)
            {
                if (guess == _secret[i])
                {
                    _guesses[i] = guess;
                }
            }   
        }

        public string ToString()
        {
            string s = "";
            foreach (string item in _guesses)
            {
                s += item;
            }
            
            return s;
        }

        

    }
}