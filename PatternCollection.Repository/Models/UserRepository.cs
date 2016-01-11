using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PatternCollection.Repository.Database;
using PatternCollection.Repository.Interfaces;

namespace PatternCollection.Repository.Models
{
    public class UserRepository : BaseRepository, IRepository<User, Guid>
    {
        public UserRepository(PatternCollectionEntities patternContext) : base(patternContext)
        {

        }

        public void Add(User model)
        {
            patternContext.User.Add(model);
            SaveChanges();
        }

        public User Get(Guid id)
        {
            return patternContext.User.FirstOrDefault(user => user.UserId == id);
        }

        public IEnumerable<User> GetAll()
        {
            return patternContext.User;
        }

        public void Update(User model)
        {
            patternContext.Entry(model).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(User model)
        {
            patternContext.User.Remove(model);
            SaveChanges();
        }
    }
}
