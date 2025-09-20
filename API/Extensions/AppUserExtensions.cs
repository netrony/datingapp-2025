using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;

namespace API.Extensions
{
    public static class AppUserExtensions
    {
        public static UserDto ToDto(this Entities.AppUser user, ITokenService tokenService)
        {

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                DisplayName = user.DisplayName,
                Token = tokenService.CreateToken(user)
            };
        }
    }
}