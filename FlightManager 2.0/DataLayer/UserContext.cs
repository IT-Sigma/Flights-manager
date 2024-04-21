using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserContext : IDb<User, int>
    {
        private FlightManagerDbContext _dbContext;

        public UserContext(FlightManagerDbContext dbContext)
        {
            _dbContext = dbContext;  
        }

        public async Task CreateAsync(User item)
        {
            try
            {
                _dbContext.Users.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<User>> ReadAllAsync(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<User> query = _dbContext.Users;

                if (useNavigationProperties)
                {
                    query = query.Include(u => u.Reservation)
                            .ThenInclude(re => re.User);
                }

                return await query.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<User> ReadAsync(int key, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<User> query = _dbContext.Users;

                if (useNavigationProperties)
                {
                    query = query.Include(u => u.Reservation)
                            .ThenInclude(re => re.User);
                }

                return await query.FirstOrDefaultAsync(u => u.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task UpdateAsync(User item, bool useNavigationProperties = false)
        {
            try
            {
            _dbContext.Users.Update(item);
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
                _dbContext.Users.Remove(await ReadAsync(key));
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
