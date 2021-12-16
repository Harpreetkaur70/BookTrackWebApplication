using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackWebApplication.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string NameToken { get; set; }

        public string Description { get; set; }

        [ForeignKey("CategoryType")]
        public int CategoryTypeId { get; set; }
        public CategoryType CategoryType { get; set; }
    }
}
