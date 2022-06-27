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
        string idrol;
        int codcarr;
        string nombrecarr;
        string nombrecurso;
        string escuelacarr;

        public EquivMoodleUmas() { }

        public string Idrol { get => idrol; set => idrol = value; }
        public int Codcarr { get => codcarr; set => codcarr = value; }
        public string Nombrecarr { get => nombrecarr; set => nombrecarr = value; }
        public string Nombrecurso { get => nombrecurso; set => nombrecurso = value; }
        public string Escuelacarr { get => escuelacarr; set => escuelacarr = value; }
    }
}
