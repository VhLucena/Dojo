using System;
using System.Collections.Generic;
using System.Linq;
using Application.Exceptions;

namespace Application
{
    public class Validator
    {
        private readonly List<string> _dictionary;

        public Validator(List<string> dictionary)
        {
            if (dictionary is null)
            {
                throw new InvalidDictionaryException();
            }

            _dictionary = dictionary;
        }

        public void IsValidSequence(List<string> words, string first, string last)
        {
            AreValidEdges(words, first, last);
            AreValidWords(words);
            AreValidChanges(words);
        }

        public void AreValidEdges(List<string> words, string first, string last)
        {
            if (words.Count == 0)
            {
                throw new InvalidWordsException();
            }
            
            if (words.First() != first || words.Last() != last)
            {
                throw new Exception();
            }
        }

        public void AreValidWords(List<string> words)
        {
            foreach (var word in words)
            {
                if (!_dictionary.Contains(word))
                {
                    throw new InvalidWordException();
                }
            }
        }

        public void AreValidChanges(List<string> changes)
        {
            for (int i = 0; i < changes.Count-1; i++)
            {
                if (changes[i].Length != changes[i + 1].Length)
                {
                    throw new InvalidChangeException();
                }

                int changesCount = 0;
                for (int j = 0; j < changes[i].Length; j++)
                {
                    if (changes[i][j] != changes[i + 1][j])
                    {
                        changesCount++;
                    }
                    if (changesCount > 1)
                    {
                        throw new InvalidChangeException();
                    }
                }
            }
        }
    }
}
