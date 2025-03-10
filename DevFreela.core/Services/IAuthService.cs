using System;

namespace DevFreela.core.Services
{


public interface IAuthService
{
   //role -> papel para o usuario
        string GenerateJwtToken(string email, string role);
        string ComputedSha256Hash(string password);
}

}