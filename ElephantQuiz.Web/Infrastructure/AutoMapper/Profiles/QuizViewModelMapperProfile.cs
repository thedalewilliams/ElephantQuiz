﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
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
                ;
        }
    }
}