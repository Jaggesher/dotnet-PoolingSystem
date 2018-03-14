using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_PoolingSystem.Models;

namespace dotnet_PoolingSystem.Services
{
    public interface IPoolingService
    {
        Task<String> addEvent();
        Task<IEnumerable<Event>> getAll();
        Task<bool> CheckVote(Guid eventId,String voterRoll);

     }
}
