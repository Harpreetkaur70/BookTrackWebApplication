using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackWebApplication.Models
{
    public class CategoryType
    {
        [Key]
        public int CategoryTypeID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
