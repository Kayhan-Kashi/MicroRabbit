using System;
using System.Collections.Generic;
using System.Text;

namespace MicoRabbit.Domain.Core.Events
{
    public class Event
    {
        protected Event()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; protected set; }
    }
}
