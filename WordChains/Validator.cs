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
            // "cat", "dog"
            for (int i = 0; i < changes.Count-1; i++)
            {
                int changesCount = 0;
                for (int j = 0; j < changes[i].Length; j++)
                {
                    if (changes[i][j] != changes[i + 1][j])
                    {
                        changesCount++;
                    }
                    if (changesCount > 1)
                    {
                        throw new Exception();
                    }
                }
            }

        }
    }
}
