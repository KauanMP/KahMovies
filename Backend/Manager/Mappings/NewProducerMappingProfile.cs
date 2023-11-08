using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.ModelViews.Producers;

namespace Manager.Mappings
{
    public class NewProducerMappingProfile : Profile
    {
        public NewProducerMappingProfile()
        {
            CreateMap<Producer, NewProducer>().ReverseMap();
            CreateMap<Producer, ProducerReference>().ReverseMap();
            CreateMap<Producer, ProducerView>().ReverseMap();
            CreateMap<ProducerUpdate, Producer>().ReverseMap();
        }
    }
}