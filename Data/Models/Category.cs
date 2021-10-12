using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.Models
{
    public class Category
    {

        public int id { get; set; }

        public string categoryName { get; set; }

        public string desc { get; set; }

        public List<Bun> buns { get; set; }


    }
}
