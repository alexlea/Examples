using System;

namespace CommandHandlerExample.valuetypes
{
    internal class MessageId
    {
        private Guid _messageId;

        public MessageId()
        {
            _messageId = Guid.NewGuid();
        }

        public MessageId(Guid messageId)
        {
            if (messageId == Guid.Empty)
                throw new ArgumentException("Message Id cannot be the empty Guid");

            _messageId = messageId;
        }

        public Guid ToGuid()
        {
            return _messageId;
        }
    }
}