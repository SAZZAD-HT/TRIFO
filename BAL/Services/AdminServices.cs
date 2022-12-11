using AutoMapper;
using BAL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAL.Services
{
    internal class AdminServices
    {
        public static List<AdminDto> GetAdmin()
        {
            var data = DataAcessFactory.AdminDataAcess().GetType();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, AdminDto>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<AdminDto>>(data);
            return converted;
            //return data;
        }
        public static AdminDto Get(int id)
        {
            var data = DataAcessFactory.AdminDataAcess().get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, AdminDto>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<AdminDto>(data);
            return converted;
        }
        public static bool Add(AdminDto grp)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDto, Group>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Group>(grp);
            var rs = DataAcessFactory.AdminDataAcess().add(converted);
            return (bool)rs;
        }
    }
}
