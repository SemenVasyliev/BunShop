using Shop2.Data.Interfaces;
using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.mocks
{
    public class MockCategory : IBunsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Сладкая выпечка", desc = "Булки с начинкой из крема, ягод и тд." },
                    new Category {categoryName = "Мясная выпечка", desc = "Булки с мясной начинкой"}
                };
            }
        }
    }
}
