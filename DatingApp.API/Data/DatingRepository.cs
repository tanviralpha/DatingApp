using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DatingRepository : IDatingRepository
    {
        // As we are saving data in a method we need to bring the data context.
        // Thats why we need to add a constructor
        public DataContext _Context { get; set; }

        public DatingRepository(DataContext Context)
        {
            _Context = Context;
 
        }
        public void Add<T>(T entity) where T : class
        {
            //passing entity as parameter
            _Context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _Context.Remove(entity);
        }

        public async Task<User> GetUser(int Id)
        {
            // Include photos that is coming from entity framework.

            var user = await _Context.Users.Include(p =>p.Photos).FirstOrDefaultAsync(u => u.Id == Id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var user = await _Context.Users.Include(p => p.Photos).ToListAsync();
            return user;
        }

        public async Task<bool> Saveall()
        {
            // return true if the result is greater than 0
            return await _Context.SaveChangesAsync() > 0;
        }
    }
}