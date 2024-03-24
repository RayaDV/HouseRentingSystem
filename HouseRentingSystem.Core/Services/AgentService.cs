using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Services
{
    public class AgentService : IAgentService
    {
        private readonly IRepository repository;
        public AgentService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repository
                .AllReadOnly<Agent>()
                .AnyAsync(a => a.UserId == userId);
        }
    }
}
