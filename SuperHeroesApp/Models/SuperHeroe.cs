using SuperHeroesApp.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe:Heroe , ISuperHeroe
    {
        
        private string _Name;
        public int Id { get; set; } = 1;

        
        public override string Name
        {
            get 
            { 
                return _Name;
            }
            set
            {
                _Name = value.Trim();
            }
        }
        public string NombreEIdentidadSecreata
        {
            get
            {
                return $"{Name} ({IdentidadSecreta})";
            }
            
        }
        

        public string IdentidadSecreta { get; set; }
        public string Cuidad;
        public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
            //UsarSuperPoderes();

        }
        public String UsarSuperPoderes()


        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreata} esta usado el super poder {item.Nombre}!!!");
            }
            return sb.ToString();
        }
        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreata} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreata} ha salvado la tierra";
        }
    }
}
