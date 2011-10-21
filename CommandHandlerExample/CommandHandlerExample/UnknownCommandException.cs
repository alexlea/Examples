using System;

namespace CommandHandlerExample
{
    internal class UnknownCommandException : Exception
    {
        public UnknownCommandException(string command)
        {
            throw new NotImplementedException();
        }
    }
}