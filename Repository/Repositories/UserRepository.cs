using System;
using Domain.Models;
using Domain.Repositories;
using System.Data.SqlClient;
using Dommel;
using System.Linq;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Repository.Mapping;
using System.Collections.Generic;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private SqlConnection _connection;

        public UserRepository(SqlConnection connection)
        {
            _connection = connection;

            //todo: improve this method
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new UserMap());                
                config.ForDommel();
            });
        }

        public User Add(User user)
        {
            _connection.Insert(user);

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _connection.GetAll<User>();
        }

        public User GetById(int id)
        {
            return _connection.Select<User>(p => p.Id == id).FirstOrDefault();
        }

        public void Update(User user)
        {
            _connection.Update(user);
        }
    }
}
