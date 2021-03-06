﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToBrasil.Domain.Entities;

namespace ToBrasil.Domain.Interfaces.Repository
{
    public interface IUserRepository : IBaseRepository<Users>
    {
        Task<Users> GetUserByEmailAsync(Users user);
    }
}
