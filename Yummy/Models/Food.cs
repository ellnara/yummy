using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yummy.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
