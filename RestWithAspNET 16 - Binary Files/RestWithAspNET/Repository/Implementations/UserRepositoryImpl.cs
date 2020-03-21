using System;
using System.Linq;
using RestWithAspNET.Model;
using RestWithAspNET.Model.Context;

namespace RestWithAspNET.Repository.Implementations
{
    public class UserRepositoryImpl : IUserRepository
    {
        private MySqlContext _context;
        public UserRepositoryImpl(MySqlContext context)
        {
            _context = context;
        }

        

        public User FindByIdLogin(string login)
        {
            return _context.Users.SingleOrDefault(p => p.Login.Equals(login));
        }

        

        
    }
}
