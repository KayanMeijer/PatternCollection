using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCollection.Repository.Interfaces;

namespace PatternCollection.Repository.Models
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            
        }

        public void Save(User model)
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(User model)
        {
            throw new NotImplementedException();
        }

        public void Delete(User model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
