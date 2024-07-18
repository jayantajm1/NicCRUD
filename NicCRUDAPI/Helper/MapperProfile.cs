using AutoMapper;
using NicCRUDAPI.DAL.Entity;
using NicCRUDAPI.Models;

namespace NicCRUDAPI.Helper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<User,UserModel>().ReverseMap();
        }
    }
}
