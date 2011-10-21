namespace CommandHandlerExample
{
    public class CommandHandler
    {
        ICommandDeserializer _deserializer;

        public CommandHandler(ICommandDeserializer deserializer)
        {
            _deserializer = deserializer;
        }

        public void HandleCommand(string command)
        {
            ICommand command;
            try
            {
                command = _deserializer.ParseCommand(command);
            }
            catch (CommandDeserializationException cde)
            {
                // log or queue error
            }

            try
            {
                command.Execute();
            }
            catch (CommandExecutionException cee)
            {
                // log or queue error
            }
        }
    }
}