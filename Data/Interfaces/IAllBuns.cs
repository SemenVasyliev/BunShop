using Shop2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.Interfaces
{
    public interface IAllBuns
    {
        IEnumerable<Bun> Buns { get; }
        IEnumerable<Bun> getFavBuns { get; set; }
        Bun getObjectBun(int bunId);
    }
}
