using HotelsApi.Contracts;
using HotelsApi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelsApiDbContext _context;
        public CountriesRepository(HotelsApiDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            var record = _context.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(h => h.Id == id);

            return await record;
        }
    }
}
