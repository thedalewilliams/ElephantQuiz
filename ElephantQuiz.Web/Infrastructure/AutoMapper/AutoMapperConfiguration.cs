using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ElephantQuiz.Web.Infrastructure.AutoMapper.Profiles;

namespace ElephantQuiz.Web.Infrastructure.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.AddProfile<QuizViewModelMapperProfile>();
        }
    }
}