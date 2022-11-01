using ProductEntity;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DAL.Repository
{
    public interface IArticleRepo
    {
        void AddArticle(Article article);

        void UpdateArticle(Article article);

        void DeleteArticle(int articleId);

        Article GetArticleById(int articleId);
        IEnumerable<Article> GetArticles();
    }
}
