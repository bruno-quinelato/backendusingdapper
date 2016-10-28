using Domain.Models;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        User Add(User user);
        User GetById(int id);
        void Update(User user);
        IEnumerable<User> GetAll();
    }
}
