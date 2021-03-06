﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToBrasil.Application.DTO;
using ToBrasil.Domain.Entities;

namespace ToBrasil.Application.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<CadastroInputDTO, Users>()
                .ForMember(entity => entity.UserName, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(entity => entity.PasswordHash, opt => opt.MapFrom(dto => dto.Password));                
            CreateMap<Users, CadastroInputDTO>();

            CreateMap<CadastroOutputDTO, Users>();
            CreateMap<Users, CadastroOutputDTO>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(entity => entity.UserName));

            CreateMap<LoginInputDTO, Users>()
                .ForMember(entity => entity.PasswordHash, opt => opt.MapFrom(dto => dto.Password));
            CreateMap<Users, LoginInputDTO>();

            CreateMap<LoginOutputDTO, Users>();
            CreateMap<Users, LoginOutputDTO>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(entity => entity.UserName));

            CreateMap<TokenDTO, Token>();
            CreateMap<Token, TokenDTO>();

            CreateMap<PhoneDTO, Phone>();
            CreateMap<Phone, PhoneDTO>();
        }
    }
}
