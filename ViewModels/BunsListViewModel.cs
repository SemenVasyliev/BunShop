using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.ViewModels
{
    public class BunsListViewModel
    {
        public IEnumerable<Bun> allBuns { get; set; }

        public string currCategory { get; set; }
    }
}
