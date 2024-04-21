using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ReservationContext : IDb<Reservation, int>
    {
        private FlightManagerDbContext _dbContext;

        public ReservationContext(FlightManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(Reservation item)
        {
            try
            {
                _dbContext.Reservations.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Reservation>> ReadAllAsync(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Reservation> query = _dbContext.Reservations;

                if (useNavigationProperties)
                {
                    query = query.Include(re => re.User)
                            .ThenInclude(u => u.Reservation).
                            Include(re => re.Flight).
                            ThenInclude(f => f.Reservation);
                }

                return await query.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Reservation> ReadAsync(int key, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Reservation> query = _dbContext.Reservations;

                if (useNavigationProperties)
                {
                    query = query.Include(re => re.User)
                            .ThenInclude(u => u.Reservation).
                            Include(re => re.Flight).
                            ThenInclude(f => f.Reservation);
                }

                return await query.FirstOrDefaultAsync(re => re.ReservationId == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAsync(Reservation item, bool useNavigationProperties = false)
        {
            try
            {
                _dbContext.Reservations.Update(item);
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
                _dbContext.Reservations.Remove(await ReadAsync(key));
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
