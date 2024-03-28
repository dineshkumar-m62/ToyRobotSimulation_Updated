using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Repository.IRepository
{
    public interface ICommand
    {
        void PlaceCommand(int x, int y, string direction);

        void MoveCommand();

        void LeftCommand();

        void RightCommand();

        void ReportCommand();
    }
}
