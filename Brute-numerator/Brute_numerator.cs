using System;
using System.Collections;
using System.Collections.Generic;

namespace Brute_numerator
{

    public class BruteSequence : IEnumerable<string>
    {
        private Brute_numerator _base;
        private char[] numbersArray;

        public BruteSequence()
        {
            _base = new Brute_numerator();
        }

        public BruteSequence(char[] currentArray)
        {
            _base = new Brute_numerator(currentArray);
        }

        public ulong NumberGenerated => _base.NumberPasswordsGenerated;

        public IEnumerator<string> GetEnumerator()
        {
            return _base;
        }


        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Brute_numerator : IEnumerator<string>
    { 
        private char[] _charactersToTest;
        private ulong _characterCount;

        private Int16[] _indexes;
        private string password;

        public ulong NumberPasswordsGenerated = 0;

        public string Current => GetCurrent();

        object IEnumerator.Current => GetCurrent();

        public Brute_numerator()
        {
            Setup(CharacterArrays.DefaultArray);
        }

        public Brute_numerator(char[] defaultArray)
        {
            Setup(defaultArray);
        }

        private void Setup(char[] characterArray, int length = 5)
        {
            NumberPasswordsGenerated = 0;
            _charactersToTest = characterArray;
            _characterCount = (ulong)characterArray.Length;
        }

        
        public bool MoveNext()
        {
            Increment();
            return true;
        }
        private string GetCurrent()
        {
            return password;
        }
        private void Increment()
        {
            password = "";
            ulong current = NumberPasswordsGenerated++;

            do
            {
                password = _charactersToTest[current % _characterCount] + password;
                current /= _characterCount;
            } while (current != 0);
        }

        public void Reset()
        {
            Setup(_charactersToTest);
        }

        public void Dispose()
        {
           
        }
    }
}
