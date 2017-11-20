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

        public IEnumerable<char> Next()
        {
            _number += 1;

            if (_number == 3) return "Fizz";

            if (_number == 5) return "Buzz";

            return _number.ToString();
        }
    }
}
