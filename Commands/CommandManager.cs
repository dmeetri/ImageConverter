namespace Commands
{
    public class CommandManager
    {
        private ImageEdit ie = new ImageEdit();

        public void readCommands()
        {
            Console.WriteLine("Type 'help' for help");
            string? input = Console.ReadLine();

            string[] args = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            runCommand(args);
        }

        private void runCommand(String[] args)
        {
            switch (args[0].ToLower())
            {
                case "help":
                    Console.Write(helpMessage());
                    break;
                case "resize":
                    if (args.Length < 2)
                        Console.WriteLine("ERROR: You did not specify all the subscriptions! Write down 'help'");

                    if (int.TryParse(args[2], out int height)) ie.resize(args[1], height);
                    else Console.WriteLine("ERROR: You entered an incorrect value. The expected number is");
                    break;
                    /*
            

            if (int.TryParse(args[2], out int height)) ie.Resize(args[1], height);
            else Console.WriteLine("ERROR: You entered an incorrect value. The expected number is");
            break;
            */
                case "convert":
                    break;
                case "deletedata":
                    break;
                default:
                    Console.Write(helpMessage());
                    break;
            }
        }

        private string helpMessage()
        {
            return "help - all commands\n" +
                "resize <image / folder with pictures> <height> - Resizing the image while maintaining the proportions\n" +
                "convert <image / folder with pictures> <format - png jpg web>\n" +
                "deleteData <image / folder with pictures>";
        }
    }
}
