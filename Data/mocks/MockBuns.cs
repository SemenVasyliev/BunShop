using Shop2.Data.Interfaces;
using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.mocks
{
    public class MockBuns : IAllBuns
    {

        private readonly IBunsCategory _categoryBuns = new MockCategory();
        public IEnumerable<Bun> Buns 
        {
            get
            {
                return new List<Bun>
                {
                    new Bun 
                    {
                        name = "Клубничный штрудель", 
                        shortDesc = "Штрудель с начинкой из клубники", 
                        longDesc = "Для любителей сладкого отлично подойдет",
                        img = "https://img.fresh.ru/unsafe/1440x960/https%3A%2F%2Fimg.fresh.ru%2Ffresh-recipe-20210703%2F2467-b62dcd6755f0a89ff832131a4611f211b5876514.jpg", 
                        price = 45, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryBuns.AllCategories.First()
                    },
                    new Bun
                    {
                        name = "Пирожок с курицей",
                        shortDesc = "Пирожок с начинкой из куриного мяса",
                        longDesc = "Отлично подойдет для тех, кто хочет сытно поесть",
                        img = "https://vilkin.pro/wp-content/uploads/2019/01/pirozki-s-kuricei-770x513.jpg",
                        price = 55,
                        isFavourite = false,
                        available = true,
                        Category = _categoryBuns.AllCategories.Last()
                    },
                     new Bun
                    {
                        name = "Пирожок с говядиной",
                        shortDesc = "Пирожок с начинкой из говяжего мяса",
                        longDesc = "Отлично подойдет для тех, кто хочет сытно поесть",
                        img = "https://vilkin.pro/wp-content/uploads/2019/01/pirozki-s-kuricei-770x513.jpg",
                        price = 55,
                        isFavourite = true,
                        available = true,
                        Category = _categoryBuns.AllCategories.Last()
                    },
                      new Bun
                    {
                        name = "Пирожок с картошкой",
                        shortDesc = "Пирожок с начинкой из картошки",
                        longDesc = "Отлично подойдет для тех, кто хочет сытно поесть",
                        img = "https://vilkin.pro/wp-content/uploads/2019/01/pirozki-s-kuricei-770x513.jpg",
                        price = 55,
                        isFavourite = false,
                        available = false,
                        Category = _categoryBuns.AllCategories.Last()
                    },
                       new Bun
                    {
                        name = "Пирожок с малиной",
                        shortDesc = "Пирожок с малиновой начинкой",
                        longDesc = "Отлично подойдет для тех, кто хочет сытно поесть",
                        img = "https://vilkin.pro/wp-content/uploads/2019/01/pirozki-s-kuricei-770x513.jpg",
                        price = 55,
                        isFavourite = true,
                        available = true,
                        Category = _categoryBuns.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Bun> getFavBuns { get ; set; }

        public Bun getObjectBun(int bunId)
        {
            throw new NotImplementedException();
        }
    }
}
