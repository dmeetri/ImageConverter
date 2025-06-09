using System;
using Commands;

class Program
{
    public static void Main(string[] args)
    {
        CommandManager cmd = new CommandManager();

        while (true)
        {
            cmd.readCommands();
        }
    }
}

