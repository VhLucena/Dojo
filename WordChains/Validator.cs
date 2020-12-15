using System;
using System.Collections.Generic;
using WordChains.Exceptions;

namespace WordChains
{
    public class Validator
    {
        private readonly List<string> _dictionary;

        public Validator(List<string> dictionary)
        {
            _dictionary = dictionary;
        }

        public void IsValidWords(List<string> words)
        {
            foreach (var word in words)
            {
                if (!_dictionary.Contains(word))
                {
                    throw new InvalidWordException();
                }
            }
        }

        public void IsValidChanges(List<string> changes)
        {

        }
    }
}
