using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class GuessingGame
    {
        private const int MAX_NUMBER = 100;
        private const int MIN_NUMBER = 1;

        private int _numberOfGuesses;
        private int _currentNumber;
        private int _currentGuess;
        private Random _nextNumber;
        private int _minValue;
        private int _maxValue;

        public int NumberOfGuesses
        {
            get { return _numberOfGuesses; }
        }

        /// <summary>
        /// Starts a new round by choosing a random number
        /// </summary>
        public void StartRound()
        {
            _currentNumber = _nextNumber.Next(_minValue, _maxValue + 1);
            _numberOfGuesses = 0;
        }

        /// <summary>
        /// Checks the users guess against the current answer and returns true if they are the same
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckAnswer(int value)
        {
            _currentGuess = value;
            if (_currentGuess == _currentNumber)
            {
                return true;
            }
            else
            {
                _numberOfGuesses++;
                return false;
            }
        }

        public string CheckGreaterThanLessThan()
        {
            string result;
            if (_currentGuess > _currentNumber)
            {
                result = "The value you entered is too high.";
            }
            else
            {
                result = "The value you entered is too low";
            }
            return result;
        }

        public GuessingGame(int minVal = MIN_NUMBER, int maxVal = MAX_NUMBER)
        {
            _numberOfGuesses = 0;
            _nextNumber = new Random();
            _minValue = minVal;
            _maxValue = maxVal;
        }
    }
}