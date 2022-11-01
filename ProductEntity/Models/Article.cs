using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ProductEntity.Models;

namespace ProductEntity.Models
{
    [Table("Articles")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  
        public Guid ArticleId { get; set; }      
        public string ArticleName { get; set; } 
       
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("SizeScale")]
        public Guid SizeId { get; set; }
        public SizeScale SizeScale { get; set; }

        [ForeignKey("Color")]
        public Guid ColorId { get; set; }
        public Colour Color { get; set; }
    } 
}
