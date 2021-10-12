using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.Interfaces
{
   public interface IBunsCategory
    {
       IEnumerable<Category> AllCategories { get; }
    }
}
