using System;
namespace UnitTestKata
{
    public class BowlingKata
    {
        int rollcounter = 0;
        int[] rolls = new int[21];

        public BowlingKata()
        {
        }

        public void roll(int pins)
        {
            rolls[rollcounter++] = pins;
        }

        public int score()
        {
            int gameScore = 0;
            int frameIndex = 0;

            // iterate over rolls two at a time (frame)
            for (int frame = 0; frame < 10; frame++)
            {
                //
                if (isStrike(frameIndex))
                {
                    gameScore += strikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (isSpare(frameIndex))
                {
                    gameScore += spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else 
                {
                    gameScore += sumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return gameScore;
        }

        bool isSpare(int frameIndex)
        {
            // spare if both frames add up to 10 pins
            return (rolls[frameIndex] + rolls[frameIndex + 1] == 10);
            
        }

        bool isStrike(int frameIndex)
        {
            return (rolls[frameIndex] == 10);
        }

        int sumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        int spareBonus (int frameIndex)
        {
            return 10 + rolls[frameIndex + 2];
        }

        int strikeBonus(int frameIndex)
        {
            return 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
    }
}

