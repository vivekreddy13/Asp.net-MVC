using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vivek.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
