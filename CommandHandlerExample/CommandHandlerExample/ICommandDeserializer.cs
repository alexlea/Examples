namespace CommandHandlerExample
{
    interface ICommandDeserializer
    {
        ICommand ParseCommand(string command);
    }
}