﻿using RestWithAspNET.Data.Converter;
using RestWithAspNET.Data.VO;
using RestWithAspNET.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithAspNET.Data.Converters
{
    public class UserConverter : IParse<UserVO, User>, IParse<User, UserVO>
    {
        public User Parse(UserVO origin)
        {
            if (origin == null) return new User();
            return new User
            {
                Login = origin.Login,
                AccessKey = origin.AccessKey
            };
        }

        public UserVO Parse(User origin)
        {
            if (origin == null) return new UserVO();
            return new UserVO
            {
                Login = origin.Login,
                AccessKey = origin.AccessKey
            };
        }

        public List<User> ParseList(List<UserVO> origin)
        {
            if (origin == null) return new List<User>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<UserVO> ParseList(List<User> origin)
        {
            if (origin == null) return new List<UserVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
