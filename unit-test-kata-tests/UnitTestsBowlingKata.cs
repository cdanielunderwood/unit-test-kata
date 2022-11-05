using System;
using UnitTestKata;

namespace UnitTestKataTests
{
    public class UnitTestsBowlingKata
    {
        BowlingKata game;

        public UnitTestsBowlingKata()
        {
            game = new BowlingKata();
        }

        [Theory]
        [InlineData(0, 0)] // roll a gutter ball
        [InlineData(1, 1)] // knock down one pin
        public void Bowling_SingleTestRoll(int pins, int expected)
        { 
            game.roll(pins);

            Assert.Equal(expected, game.score());
        }

        void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.roll(pins);
            }
        }

        void rollStrike()
        {
            game.roll(10);
        }

        void rollSpare()
        {
            game.roll(5);
            game.roll(5);
        }

        [Theory]
        [InlineData(0, 0)]   // gutter ball 20 rolls
        [InlineData(1, 20)]  // knock down 1 pin 20 rolls
        [InlineData(4, 80)] //  knock down 4 pins 20 rolls
        public void Bowling_DuplicateRollsGame_NoStrikeOrSpares(int pins, int expected)
        {
            rollMany(20, pins);
            Assert.Equal(expected, game.score());
        }

        [Fact]
        public void Bowling_FirstFrameSpareGame()
        {
            
            rollSpare();
            game.roll(3); 
            rollMany(17, 0); 
                          
            Assert.Equal(16, game.score());

        }

        [Fact]
        public void Bowling_FirstFrameStrikeGame()
        {

            rollStrike(); 
            game.roll(3); 
            game.roll(4); 
            rollMany(16, 0); 

            Assert.Equal(24, game.score());

        }

        [Fact]
        public void Bowling_PerfectGame()
        {
            rollMany(12, 10);
            Assert.Equal(300, game.score());

        }
    }
}

