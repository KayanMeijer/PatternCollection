using System;
using System.Collections.Generic;
using PatternCollection.Repository.Models;

namespace PatternCollection.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        IEnumerable<User> FindAll();
    }
}
