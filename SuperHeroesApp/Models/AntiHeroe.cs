﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiheroe(String accion)
        {
            return $"El Antiheroe  {NombreEIdentidadSecreata} ha realizado: {accion}";
        }
    }
}
