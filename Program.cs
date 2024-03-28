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

        //string commands = @"C:\Users\D0861164\source\repos\ToyRobot\Command\commands.txt";
        var commands = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "commands.txt");

        //Console.WriteLine("commands", commands);

        try
        {
            using (StreamReader sr = new StreamReader(commands))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                { 
                    //Console.WriteLine("line", line);
                    //var cmd = commandParser.ParseCommand(line);
                    commandParser.ParseCommand(line);
                    //if (cmd != null)
                    //    cmd.Execute(robot);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"The file could not be read: {e.Message}");
        }
    }
}