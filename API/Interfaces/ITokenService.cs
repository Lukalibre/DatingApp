using System;
using API.Entities;
using API.Extensions;

namespace API.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);

}
