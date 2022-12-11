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
    internal class CaseServices
    {
        public static List<CaseDto> GetCase()
        {
            var data = DataAcessFactory.CaseDataAcess().GetType();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, CaseDto>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<CaseDto>>(data);
            return converted;
            //return data;
        }
        public static CaseDto Get(int id)
        {
            var data = DataAcessFactory.CaseDataAcess().get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Group, CaseDto>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<CaseDto>(data);
            return converted;
        }
        public static bool Add(CaseDto grp)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CaseDto, Group>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Group>(grp);
            var rs = DataAcessFactory.CaseDataAcess().add(converted);
            return (bool)rs;
        }
    }
}
