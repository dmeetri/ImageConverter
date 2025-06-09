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
                    ie.Resize(args[1], args[2], args[3]);
                    break;
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
            return "help - all commands \n" +
                "resize <image / folder with pictures> <width / height?> \n" +
                "convert <image / folder with pictures> <format - png jpg web> \n" +
                "deleteData <image / folder with pictures>";
        }
    }
}
