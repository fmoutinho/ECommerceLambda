using EcommerceLambda.Domain.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceLambda.Application.Abstractions
{
    public interface IMessager
    {
        Task Produce(Request request);
    }
}
