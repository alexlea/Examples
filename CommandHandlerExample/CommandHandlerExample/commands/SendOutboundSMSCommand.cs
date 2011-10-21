using System;

namespace CommandHandlerExample
{
    internal class SendOutboundSMSCommand : ICommand
    {
        public SendOutboundSMSCommand(Guid messageId, string recipient, string body)
        {
            MessageId = messageId;
            Recipient = recipient;
            Body = body;
        }

        public Guid MessageId { get; private set; }
        public string Recipient { get; private set; }
        public string Body { get; private set; }       

        public void Execute()
        {
            // command processing logic goes here. most likely a script of interactions with the domain
            // i.e. Create OutboundSMS domain object, save and call Send method
            // maybe you do something else in a more complex command? not sure
        }     
    }
}