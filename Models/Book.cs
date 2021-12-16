using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackWebApplication.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }

    }
}
