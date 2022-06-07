using Microsoft.AspNetCore.Mvc;
using P_MOOU_.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class EquivMoodleUmas
    {
        int idcourse;
        string codcarr;
        string nombre;

        public EquivMoodleUmas() { }
        public int Idcourse { get => idcourse; set => idcourse = value; }
        public string Codcarr { get => codcarr; set => codcarr = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        
    }
}
