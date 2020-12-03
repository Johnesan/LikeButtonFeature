using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Gets the user for the Id specified. In production, a UserDTO should be 
        /// used in place of User as the return type. I didn't make use of this service 
        /// in any controller that's why I'm skipping that. Make the necessary adjustments 
        /// if you make use of this method definition. You don't want clients to see 
        /// every single detail represented in your db :)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<User> GetUser(int Id);
    }
}
