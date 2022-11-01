using Product.DAL.Repository;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Bussiness.Services
{
    public class ArticleServices
    {
        IArticleRepo _articleRepo;
        public ArticleServices(IArticleRepo articleRepository)
        {
            _articleRepo = articleRepository;
        }
        public void AddArticle(Article article)
        {
            _articleRepo.AddArticle(article);
        }
        public void UpdateArticle(Article article)
        {
            _articleRepo.UpdateArticle(article);
        }
        public void DeleteArticle(int articleId)
        {
            _articleRepo.DeleteArticle(articleId);
        }

        public IEnumerable<Article> GetArticles()
        {
            return _articleRepo.GetArticles();
        }
        public Article GetArticleByid(int articleId)
        {
            return _articleRepo.GetArticleById(articleId);
        }
    }
}
