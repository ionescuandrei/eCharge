using AutoMapper;
using eChargeAPI.DTOs;
using eChargeAPI.Models;

namespace eChargeAPI.Helpers
{
    public class AutoMapperProfile:Profile    
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}
