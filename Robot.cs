using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot
{
    public class Robot
    {
        private readonly string[] _directions = { "NORTH", "EAST", "SOUTH", "WEST" };

        public int X { get; private set; }
        public int Y { get; private set; }
        public string Direction { get; private set; }

        private readonly Tabletop _tabletop;

        public Robot(Tabletop tabletop)
        {
            _tabletop = tabletop;
        }

        public void Place(int x, int y, string direction)
        {
            if (IsValidPosition(x, y) && Array.IndexOf(_directions, direction) != -1)
            {
                X = x;
                Y = y;
                Direction = direction;
            }
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < _tabletop.Width && y >= 0 && y < _tabletop.Height;
        }

        public void Move()
        {
            switch (Direction)
            {
                case "NORTH" when Y < _tabletop.Height - 1:
                    Y++;
                    break;
                case "EAST" when X < _tabletop.Width - 1:
                    X++;
                    break;
                case "SOUTH" when Y > 0:
                    Y--;
                    break;
                case "WEST" when X > 0:
                    X--;
                    break;
            }
        }

        public void Left()
        {
            var currentDirectionIndex = Array.IndexOf(_directions, Direction);
            Direction = _directions[(currentDirectionIndex + 3) % 4];
        }

        public void Right()
        {
            var currentDirectionIndex = Array.IndexOf(_directions, Direction);
            Direction = _directions[(currentDirectionIndex + 1) % 4];
        }

        public string Report()
        {
            return $"{X},{Y},{Direction}";
        }
    }
}
