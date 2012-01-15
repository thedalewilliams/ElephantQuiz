using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ElephantQuiz.Web.Extensions;
using ElephantQuiz.Web.Models;
using ElephantQuiz.Web.ViewModels;

namespace ElephantQuiz.Web.Infrastructure.AutoMapper.Profiles
{
    public class QuizViewModelMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<EditQuizViewModel, Quiz>()
                .ForMember(x => x.Id, o => o.Ignore())
                .ForMember(x => x.Title, o => o.MapFrom(m => m.Title))
                .ForMember(x => x.Questions, o => o.Ignore())
                ;


            Mapper.CreateMap<Quiz, DisplayQuizViewModel>()
                .ForMember(x => x.Title, o => o.MapFrom(m => m.Title))
                ;

            Mapper.CreateMap<Quiz, EditQuizViewModel>()
                .ForMember(x => x.Id, o => o.MapFrom(m => m.Id.ToIntId()))
                .ForMember(x => x.Title, o => o.MapFrom(m => m.Title))
                ;
        }
    }
}