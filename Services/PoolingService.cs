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
        private readonly ApplicationDbContext _context;

        public PoolingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> addEvent(AddEventViewModel addEvent)
        {
            Event newEvent = new Event()
            {
                Id = new Guid(),
                Title = addEvent.Title,
                Description = addEvent.Description,
                StartDateTime = addEvent.StartDateTime,
                EndDateTime = addEvent.EndDateTime
            };

            _context.Events.Add(newEvent);
            
            foreach(var Option in addEvent.Options)
            {
                Option newOption = new Option()
                {
                    Id = new Guid(),
                    Name = Option,
                    EventId = newEvent.Id
                };

                _context.Options.Add(newOption);
            }

            var tm = await _context.SaveChangesAsync();
            var expect = addEvent.Options.Count +1 ;
            return tm == expect;
        }

        public Task<bool> CheckVote(Guid eventId, string voterRoll)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> getAll()
        {
            return await _context.Events.Include(X => X.Options).ToListAsync();
        }
    }

}
