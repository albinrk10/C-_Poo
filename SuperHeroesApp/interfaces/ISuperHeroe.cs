using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Name { get; set; }
        string IdentidadSecreta { get; set; }
    }
}
