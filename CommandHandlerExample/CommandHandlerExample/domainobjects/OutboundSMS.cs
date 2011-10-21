using System;
using System.Collections.Generic;
using System.Text;
using CommandHandlerExample.valuetypes;

namespace CommandHandlerExample.domainobjects
{
    class OutboundSMS
    {
        public OutboundSMS(MessageId messageId, Recipient recipient, SMSBody body)
        {
            if (messageId == null) throw new ArgumentNullException("messageId");
            if (recipient == null) throw new ArgumentNullException("recipient");
            if (body == null) throw new ArgumentNullException("body");

            MessageId = messageId;
            Recipient = recipient;
            Body = body;
        }

        public MessageId MessageId { get; private set; }
        public Recipient Recipient { get; private set; }
        public SMSBody Body { get; private set; }

        public void Send ()
        { 
            // deliver the message somewhere 
            // use message delivery service
        }
    }
}
