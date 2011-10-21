using System;
using CommandHandlerExample.valuetypes;

namespace CommandHandlerExample
{
    class CommandDeserializer : ICommandDeserializer
    {
        public ICommand Deserialize(string command)
        {
            if (command.StartsWith("SendOutboundSMSCommand"))
            {
                // parse command contents into object                
                return new SendOutboundSMSCommand(Guid.Parse(command.Substring(10,5)),
                    command.Substring(15, 5),
                    command.Substring(20, 5));
            }

            throw new UnknownCommandException(command);
        }
    }
}