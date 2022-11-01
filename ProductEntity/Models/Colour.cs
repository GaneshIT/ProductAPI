using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEntity.Models
{
    [Table("Color")]
    public class Colour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid colourId { get; set; }
        public string colourCode { get; set; }
        public string colourName { get; set; }
    }
}
