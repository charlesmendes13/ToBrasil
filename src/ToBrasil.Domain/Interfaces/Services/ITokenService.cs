﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToBrasil.Domain.Entities;

namespace ToBrasil.Domain.Interfaces.Services
{
    public interface ITokenService : IBaseService<Token>
    {
        Task<Token> CreateTokenByLoginAsync(Users login);
    }
}
