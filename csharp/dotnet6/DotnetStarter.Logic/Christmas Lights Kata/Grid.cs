using System;

namespace GridLogic
{
    public class Grid
    {
        private readonly bool[,] _lights;

        public Grid(int width, int height)
        {
            this._lights = new bool[width, height];
        }

        public int Width => this._lights.GetLength(0);
        public int Height => this._lights.GetLength(1);

        public void TurnOn(Tuple<int, int> startPosition, Tuple<int, int> endPosition)
        {
            for (int x = startPosition.Item1; x <= endPosition.Item1; x++)
            {
                for (int y = startPosition.Item2; y <= endPosition.Item2; y++)
                {
                    this._lights[x, y] = true;
                }
            }
        }

        public void TurnOff(Tuple<int, int> startPosition, Tuple<int, int> endPosition)
        {
            for (int x = startPosition.Item1; x <= endPosition.Item1; x++)
            {
                for (int y = startPosition.Item2; y <= endPosition.Item2; y++)
                {
                    this._lights[x, y] = false;
                }
            }
        }

        public void Toggle(Tuple<int, int> startPosition, Tuple<int, int> endPosition)
        {
            for (int x = startPosition.Item1; x <= endPosition.Item1; x++)
            {
                for (int y = startPosition.Item2; y <= endPosition.Item2; y++)
                {
                    this._lights[x, y] = !this._lights[x, y];
                }
            }
        }

        public int HowManyLightsAreOn()
        {
            int count = 0;
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (this._lights[x, y])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}