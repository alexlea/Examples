namespace CommandHandlerExample
{
    public interface ICommandDeserializer
    {
        ICommand Deserialize(string command);
    }
}