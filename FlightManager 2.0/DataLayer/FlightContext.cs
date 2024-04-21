using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class FlightContext : IDb<Flight, int>
    {
        private FlightManagerDbContext _dbContext;

        public FlightContext(FlightManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(Flight item)
        {
            try
            {
                _dbContext.Flights.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Flight>> ReadAllAsync(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Flight> query = _dbContext.Flights;

                if (useNavigationProperties)
                {
                    query = query.Include(u => u.Reservation)
                            .ThenInclude(re => re.Flight);
                }

                return await query.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Flight> ReadAsync(int key, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Flight> query = _dbContext.Flights;

                if (useNavigationProperties)
                {
                    query = query.Include(u => u.Reservation)
                            .ThenInclude(re => re.Flight);
                }

                return await query.FirstOrDefaultAsync(u => u.FlightId == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAsync(Flight item, bool useNavigationProperties = false)
        {
            try
            {
                _dbContext.Flights.Update(item);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task DeleteAsync(int key)
        {
            try
            {
                _dbContext.Flights.Remove(await ReadAsync(key));
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
