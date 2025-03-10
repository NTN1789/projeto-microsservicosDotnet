using System;
using DevFreela.core.Entities;

namespace DevFreela.core.Repositories;

public interface IUserRepository
{
    Task<User> GetByIdAsync(int id);
    Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);

}
