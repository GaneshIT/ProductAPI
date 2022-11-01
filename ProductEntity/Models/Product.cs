using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ProductEntity.Models;

namespace ProductEntity.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]      
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ProductId { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="Error Status Code-406:Product name characters maximum 100")]
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int ProductYear { get; set; }
        public int ChannelId { get; set; }
        public Guid sizeScaleId { get; set; }
        public List<Article> articles { get; set; }
        public DateTime CreatedDate { get; set; }          
       public string CreatedBy { get; set; }
    }
   
}
