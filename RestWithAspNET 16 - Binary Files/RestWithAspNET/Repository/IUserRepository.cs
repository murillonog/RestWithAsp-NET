using RestWithAspNET.Model;
using System.Collections.Generic;

namespace RestWithAspNET.Repository
{
    public interface IUserRepository
    {
        User FindByIdLogin(string login);
    }
}
