using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Repository.IRepository;

namespace ToyRobot.Repository
{
    public class Command : ICommand
    {
        public readonly Robot _robot;

        public Command(Robot robot) 
        {
            _robot = robot;
        }

        public void PlaceCommand(int x, int y, string direction)
        {
            _robot.Place(x, y, direction);
        }

        public void MoveCommand()
        {
            _robot.Move();
            
        }

        public void LeftCommand()
        {
            _robot.Left();

        }

        public void RightCommand()
        {
            _robot.Right();

        }

        public void ReportCommand()
        {
            Console.WriteLine(_robot.Report());

        }

    }
}
