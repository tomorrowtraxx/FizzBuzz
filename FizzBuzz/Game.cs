using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Game
    {
        private int _number;
        public Game()
        {
            _number = 0;
        }

        public string Next()
        {
            _number += 1;

            var result = new List<string>();

            if (_number % 3 == 0) result.Add("Fizz");
            if (_number % 5 == 0) result.Add("Buzz");

            return result.Count > 0 ? string.Join(" ", result.ToArray()) : _number.ToString();
        }
    }
}
