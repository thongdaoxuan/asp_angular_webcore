using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace nercoreangular.Manager.Author.Dtos
{
    public class AuthorMapProfile : Profile
    {
        public AuthorMapProfile()
        {
            CreateMap<Models.Author, AuthorDto>();


            CreateMap<CreateAuthorInput, Models.Author>();

            CreateMap<UpdateAuthorInput, Models.Author>();


        }
    }
}
