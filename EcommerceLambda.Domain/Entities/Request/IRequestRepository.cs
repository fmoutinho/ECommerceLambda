using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceLambda.Domain.Entities.Request
{
    public interface IRequestRepository
    {
        Task Save(Request request);
    }
}
