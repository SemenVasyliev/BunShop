﻿using Shop2.Data.Interfaces;
using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
