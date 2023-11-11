using AutoMapper;
using BlogWebApp.Entity.Entities;
using BlogWebApp.Entity.ViewModels.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebApp.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
        }
    }
}
