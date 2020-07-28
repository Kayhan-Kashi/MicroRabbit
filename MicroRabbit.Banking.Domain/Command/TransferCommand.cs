using System;
using System.Collections.Generic;
using System.Text;
using MicoRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Command
{
    public abstract class TransferCommand : MicoRabbit.Domain.Core.Commands.Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }

    }
}
