using Microsoft.EntityFrameworkCore;
using Product.DAL.Data;
using ProductEntity;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product.DAL.Repository
{
    public class ArticleRepo:IArticleRepo
    {
       ProductDbContext _productDbContext;
        public ArticleRepo(ProductDbContext producDbContext)
        {
            _productDbContext = producDbContext;
        }
        public void AddArticle(Article article)
        {
            _productDbContext.articles.Add(article);
            _productDbContext.SaveChanges();
        }
        public void DeleteArticle(int articleId)
        {
            var article = _productDbContext.articles.Find(articleId);
            _productDbContext.articles.Remove(article);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<Article> GetArticles()
        {
            return _productDbContext.articles.Include(obj=>obj.Product).Include(obj => obj.Color).Include(obj => obj.SizeScale).ToList();
        }
        public void UpdateArticle(Article article)
        {
            _productDbContext.Entry(article).State = EntityState.Modified;
            _productDbContext.SaveChanges();
        }
        public Article GetArticleById(int articleId)
        {
            return _productDbContext.articles.Find(articleId);
        }
    }
}
