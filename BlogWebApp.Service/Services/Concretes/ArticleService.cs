using AutoMapper;
using BlogWebApp.Data.Repositories.Abstraction;
using BlogWebApp.Data.UnitOfWorks;
using BlogWebApp.Entity.Entities;
using BlogWebApp.Entity.ViewModels.Article;
using BlogWebApp.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebApp.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsyn();
            var map  = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }

    }
}
