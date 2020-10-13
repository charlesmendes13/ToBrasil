﻿using System;
using System.Collections.Generic;
using System.Text;
using ToBrasil.Domain.Entities;

namespace ToBrasil.Domain.Interfaces.Services
{
    public interface IUserService : IBaseService<User>
    {
        User VerifyEmail(User user);
    }
}
