namespace CommandHandlerExample
{
    public class CommandHandler
    {
        ICommandDeserializer _deserializer;

        public CommandHandler(ICommandDeserializer deserializer)
        {
            _deserializer = deserializer;
        }

        public void HandleCommand(string commandString)
        {
            ICommand command;
            try
            {
                command = _deserializer.Deserialize(commandString);
                command.Execute();
            }            
            catch (CommandDeserializationException cde)
            {
                // log or queue error
            }
            catch (CommandExecutionException cee)
            {
                // log or queue error
            }        
        }
    }
}