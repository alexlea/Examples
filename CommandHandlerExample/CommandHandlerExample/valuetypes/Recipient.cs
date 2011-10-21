using System;
using System.Linq;

namespace CommandHandlerExample.valuetypes
{
    internal class Recipient
    {
        public Recipient(string recipient)
        {
            if (recipient.Count(x => !char.IsDigit(x)) > 0)
                throw new ArgumentException("Recipient must contain only digits");
            if (recipient.Length != 11)
                throw new ArgumentException("Recipient must be 11 characters");

            Receipient = recipient;
        }

        public string Receipient { get; private set; }
    }
}