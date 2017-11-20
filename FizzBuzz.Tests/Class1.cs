using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private Game _game;

        public FizzBuzzTests()
        {
            _game = new Game();
        }

        [Fact]
        public void TestIsNumberOne()
        {
            Assert.Equal("1", _game.Next());
        }

        [Fact]
        public void TestIsNumberTwo()
        {
            _game.Next();

            Assert.Equal("2", _game.Next());
        }

        [Fact]
        public void TestIsFizz()
        {
            _game.Next();
            _game.Next();

            Assert.Equal("Fizz", _game.Next());
        }

        [Fact]
        public void TestIsNumberFour()
        {
            _game.Next();
            _game.Next();
            _game.Next();

            Assert.Equal("4", _game.Next());
        }

        [Fact]
        public void TestIsBuzz()
        {
            _game.Next();
            _game.Next();
            _game.Next();
            _game.Next();

            Assert.Equal("Buzz", _game.Next());
        }
    }
}
