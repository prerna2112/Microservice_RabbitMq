using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
   public interface IEventHandler<in TEvents>: IEventHandler
        where TEvents:Event
    {

        Task Handle(TEvents @event);
    }

    public interface IEventHandler
    {
    }
}
