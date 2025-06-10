using Commands;
using Settings;

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

