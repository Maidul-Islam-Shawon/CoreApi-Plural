using AutoMapper;
using CoreApiFundamentals.Data.Entities;
using CoreApiFundamentals.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiFundamentals.DTO
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(m => m.Venue, o => o.MapFrom(l => l.Location.VenueName))
                .ForMember(m => m.Country, o => o.MapFrom(l => l.Location.Country))
                .ReverseMap();

            //this.CreateMap<CampModel, Camp>();

            this.CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(m=>m.Speaker, opt=>opt.Ignore())
                .ForMember(m=>m.Camp, opt=>opt.Ignore());

            this.CreateMap<Speaker, SpeakerModel>().ReverseMap();
        }
    }
}
