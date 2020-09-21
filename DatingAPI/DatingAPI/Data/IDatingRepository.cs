using DatingAPI.Helpers;
using DatingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T Entity) where T : class;
        void Delete<T>(T Entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int id);

        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
    }
}
