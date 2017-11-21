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
        public void Test1IsNumberOne()
        {
            Assert.Equal("1", TestPlayGame(1));
        }

        [Fact]
        public void Test2IsNumberTwo()
        {
            Assert.Equal("2", TestPlayGame(2));
        }

        [Fact]
        public void Test3IsFizz()
        {
            Assert.Equal("Fizz", TestPlayGame(3));
        }

        [Fact]
        public void Test4IsNumberFour()
        {
            Assert.Equal("4", TestPlayGame(4));
        }

        [Fact]
        public void Test5IsBuzz()
        {
            Assert.Equal("Buzz", TestPlayGame(5));
        }

        [Fact]
        public void TestProductOf3IsFizz()
        {
            Assert.Equal("Fizz", TestPlayGame(6));
        }

        [Fact]
        public void TestProductOf5IsBuzz()
        {
            Assert.Equal("Buzz", TestPlayGame(10));
        }

        [Fact]
        public void Test15IsFizzBuzz()
        {
            Assert.Equal("Fizz Buzz", TestPlayGame(15));
        }

        private string TestPlayGame(int number)
        {
            string result = string.Empty;

            for (int i = 0; i < number; i++)
            {
                result = _game.Next();
            }

            return result;
        }
    }
}
