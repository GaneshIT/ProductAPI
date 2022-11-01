using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEntity.Models
{
    [Table("SizeScale")]
    public class SizeScale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid sizeId { get; set; }
        public string sizeName { get; set; }
    }
}
