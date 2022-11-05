
using UnitTestKata;

namespace UnitTestKataTests
{
    public class UnitTestsChristmasLightsKata
    {
        [Theory]
        [InlineData(887, 9, 959, 629)]
        public void ChristmasLights_Instruction1_TurnOn(int x1, int y1, int x2, int y2)
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();
            lights.turnOnRectangle(x1, y1, x2, y2);

            for (int i=x1; i<=x2; i++)
            {
                for (int j=y1; j<=y2; j++)
                {
                    Assert.True(lights.isOn(i, j));
                }
            }
        }

        [Theory]
        [InlineData(454, 398, 844, 448)]
        public void ChristmasLights_Instruction2_TurnOn(int x1, int y1, int x2, int y2)
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();
            lights.turnOnRectangle(x1, y1, x2, y2);

            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    Assert.True(lights.isOn(i, j));
                }
            }
        }

        [Theory]
        [InlineData(539, 243, 559, 965)]
        public void ChristmasLights_Instruction3_TurnOff(int x1, int y1, int x2, int y2)
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();
            lights.turnOffRectangle(x1, y1, x2, y2);

            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    Assert.False(lights.isOn(i, j));
                }
            }
        }

        [Theory]
        [InlineData(370, 819, 676, 868)]
        public void ChristmasLights_Instruction4_TurnOff(int x1, int y1, int x2, int y2)
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();
            lights.turnOffRectangle(x1, y1, x2, y2);

            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    Assert.False(lights.isOn(i, j));
                }
            }
        }

        [Theory]
        [InlineData(145,40, 370, 997)]
        public void ChristmasLights_Instruction5_TurnOff(int x1, int y1, int x2, int y2)
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();
            lights.turnOffRectangle(x1, y1, x2, y2);

            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    Assert.False(lights.isOn(i, j));
                }
            }
        }

        [Theory]
        [InlineData(301, 3, 808, 453)]
        public void ChristmasLights_Instruction6_TurnOff(int x1, int y1, int x2, int y2)
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();
            lights.turnOffRectangle(x1, y1, x2, y2);

            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    Assert.False(lights.isOn(i, j));
                }
            }
        }

        [Theory]
        [InlineData(351, 678, 951, 908)]
        public void ChristmasLights_Instruction7_TurnOn(int x1, int y1, int x2, int y2)
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();
            lights.turnOnRectangle(x1, y1, x2, y2);

            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    Assert.True(lights.isOn(i, j));
                }
            }
        }

        [Fact]
        public void ChristmasLights_Instruction8_Toggle()
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();


            lights.turnOnRectangle(887, 9, 959, 629);
            lights.turnOnRectangle(454, 398, 844, 448);
            lights.turnOffRectangle(539, 243, 559, 965);
            lights.turnOffRectangle(370, 819, 676, 868);
            lights.turnOffRectangle(145,40, 370, 997);
            lights.turnOffRectangle(301, 3, 808, 453);
            lights.turnOnRectangle(351, 678, 951, 908);

            lights.toggleRectangle(720, 196, 897, 994);




        }

        [Fact]
        public void ChristmasLights_Instruction9_Toggle()
        {
            ChristmasLightsKata lights = new ChristmasLightsKata();


            lights.turnOnRectangle(887, 9, 959, 629);
            lights.turnOnRectangle(454, 398, 844, 448);
            lights.turnOffRectangle(539, 243, 559, 965);
            lights.turnOffRectangle(370, 819, 676, 868);
            lights.turnOffRectangle(145, 40, 370, 997);
            lights.turnOffRectangle(301, 3, 808, 453);
            lights.turnOnRectangle(351, 678, 951, 908);

            lights.toggleRectangle(720, 196, 897, 994);
            lights.toggleRectangle(831, 394, 904, 860);

            lights.printLightGrid();



        }
        
    }
}

