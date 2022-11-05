using System;
namespace UnitTestKata
{
    public class ChristmasLightsKata
    {
        private bool[,] lightGrid = new bool[1000,1000];

        public ChristmasLightsKata()
        {
        }

        public void turnOnRectangle(int x1, int y1, int x2, int y2)
        {
            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    lightGrid[i, j] = true;
                }
            }
        }

        public void turnOffRectangle(int x1, int y1, int x2, int y2)
        {
            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    lightGrid[i, j] = false;
                }
            }
        }

        public void toggleRectangle(int x1, int y1, int x2, int y2)
        {
            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    if (lightGrid[i, j])
                    {
                        lightGrid[i, j] = false;
                    }
                    else
                    {
                        lightGrid[i, j] = true;
                    }
                }
            }
        }

        public bool isOn(int x, int y)
        {
            return lightGrid[x,y];
        }

        public void printLightGrid()
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (lightGrid[i, j])
                    {
                        System.Console.Write('1');
                    }
                    else
                    {
                        System.Console.Write('0');
                    }
                }

                System.Console.Write('\n');
            }
        }
    }
}

