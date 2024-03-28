using System;
using System.IO;
using ToyRobot;
using ToyRobot.Repository;
using ToyRobot.Repository.IRepository;

class Program
{
    static void Main(string[] args)
    {
        Tabletop tabletop = new Tabletop();
        Robot robot = new Robot(tabletop);
        Command command = new Command(robot);
        CommandParser commandParser = new CommandParser(command);

        var commands = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "commands.txt");

        try
        {
            using (StreamReader sr = new StreamReader(commands))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                { 
                     commandParser.ParseCommand(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"The file could not be read: {e.Message}");
        }
    }
}