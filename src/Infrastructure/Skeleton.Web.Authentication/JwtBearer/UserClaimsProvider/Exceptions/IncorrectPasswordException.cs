﻿namespace Skeleton.Web.Authorisation.JwtBearer.UserClaimsProvider.Exceptions
{
    using System;

    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException(string login) : base($"Password is incorrect for login {login}")
        {
        }
    }
}