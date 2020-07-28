using MicoRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicoRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }


        public DateTime TimeStamp { get; protected set; }
    }
}
