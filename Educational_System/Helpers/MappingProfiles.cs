﻿using AutoMapper;
using Educational_System.Dto;
using EducationalSystem.DAL.Models;
using System.Net;

namespace Educational_System.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Assessments, AssessmentsDto>()
                .ReverseMap();
            CreateMap<RegisterBS, ApplicationUser>()
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));

        


        }
    }
}
