using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_PoolingSystem.Models;
using dotnet_PoolingSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace dotnet_PoolingSystem.Services
{
    public class PoolingService : IPoolingService
    {
        public Task<bool> addEvent(AddEventViewModel addEvent)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckVote(Guid eventId, string voterRoll)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> getAll()
        {
            throw new NotImplementedException();
        }
    }

}
