using System;
using System.Collections.Generic;
using System.Text;

namespace MicoRabbit.Domain.Core.Events
{
    public class Message
    {
        protected Message()
        {
            MessageType = GetType().Name;
        }   

        public string MessageType { get; protected set; }
    }
}
