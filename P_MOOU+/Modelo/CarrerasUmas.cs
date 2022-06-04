using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pintermedio.Modelo
{
    public class CarrerasUmas
    {
        int codcarr;
        string carrera;

        public CarrerasUmas() { }
        public int Codcarr { get => codcarr; set => codcarr = value; }
        public string Carrera { get => carrera; set => carrera = value; }
    }
}
