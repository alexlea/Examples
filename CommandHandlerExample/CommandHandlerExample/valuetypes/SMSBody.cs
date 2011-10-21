using System;

namespace CommandHandlerExample.valuetypes
{
    internal class SMSBody
    {
        public SMSBody(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Text cannot be null or empty");
            if (text.Length > 612)    
                throw new ArgumentOutOfRangeException("Body text cannot be longer than 612 characters");            

            Text = text;
        }

        public string Text { get; private set; }
    }
}