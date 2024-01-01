using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer;
using DataAccessLayer.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class TourPackagesService
    {
        public static List<TourPackagesDTO> Get()
        {
            var data = DataAccessFactory.TourPackagesData().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TourPackages, TourPackagesDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TourPackagesDTO>>(data);
            return mapped;
        }
        public static TourPackagesDTO Get(int id)
        {
            var data = DataAccessFactory.TourPackagesData().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TourPackages, TourPackagesDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TourPackagesDTO>(data);
            return mapped;
        }
    }
}
