using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Services
{
    public interface IUserService
    {
        public Task<User> GetUser(int Id);
    }
}
