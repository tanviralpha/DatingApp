using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
        // Generic Type of method
        // Add a type of T
        // In this code we meant add a type of user where entity will be taken as parameter.
        // Where T is type of class
        // We are using T entity becasue we need to pick both user and photo at a time. Otherwise we have to add 2 method.
        // same for delete
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> Saveall();

         // To get the list of user we use IEnumerable
         // Type User. Will return users
         Task<IEnumerable<User>> GetUsers();

         Task<User> GetUser(int Id);
         
    }
}