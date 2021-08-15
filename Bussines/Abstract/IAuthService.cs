﻿using Core.Entities.Concrete;
using Core.Results;
using Core.Utilities.Security.JWT;
using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IAuthService
    {
        IResultData<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IResultData<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IResultData<AccessToken> CreateAccessToken(User user);
    }
}