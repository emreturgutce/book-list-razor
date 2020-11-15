using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace book_list_razor.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
