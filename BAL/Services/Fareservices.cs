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
   public class Fareservices
    {

        public static List<FareDto> GetFare()
        {
            var data = DataAcessFactory.FareDataAcess().GetType();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, FareDto>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<FareDto>>(data);
            return converted;
            //return data;
        }
        public static FareDto Get(int id)
        {
            var data = DataAcessFactory.FareDataAcess().get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, FareDto>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<FareDto>(data);
            return converted;
        }
        public static bool Add(FareDto grp)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<FareDto, Group>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Group>(grp);
            var rs = DataAcessFactory.FareDataAcess().add(converted);
            return (bool)rs;
        }
    }
}
