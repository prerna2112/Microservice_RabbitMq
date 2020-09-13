using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommand: Command    // We can have update transfer, reinitiate transfer, and so on, so make it abstract
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }

    }
}
