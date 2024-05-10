using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Core.Models
{
    public class Product:BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Tag> Tags { get; set; }
        public string ImageUrl { get; set; } = null!;
        [NotMapped]
        public IFormFile ImageFile { get; set; } =null!;
    }
}
