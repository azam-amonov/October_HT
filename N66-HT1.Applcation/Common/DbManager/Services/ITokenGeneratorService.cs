using System.IdentityModel.Tokens.Jwt;
using N66_HT1.Domain.Entities;

namespace N66_HT1.Application.Common.DbManager.Services;

public interface ITokenGeneratorService
{
    JwtSecurityToken GetJwtToken(User user);

    string GetToken(User user);
}
