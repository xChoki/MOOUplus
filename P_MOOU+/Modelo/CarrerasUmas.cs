using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;

namespace P_MOOU_.Modelo
{
    public class CarrerasUmas
    {
        int codcarr;
        string codcurso;
        string nombrecurso;
        string nombrecarr;
        string jornadacarr;
        string escuelacarr;
        int sedecarr;

        public CarrerasUmas() { }

        public int Codcarr { get => codcarr; set => codcarr = value; }
        public string Codcurso { get => codcurso; set => codcurso = value; }
        public string Nombrecurso { get => nombrecurso; set => nombrecurso = value; }
        public string Nombrecarr { get => nombrecarr; set => nombrecarr = value; }
        public string Jornadacarr { get => jornadacarr; set => jornadacarr = value; }
        public string Escuelacarr { get => escuelacarr; set => escuelacarr = value; }
        public int Sedecarr { get => sedecarr; set => sedecarr = value; }

    }

}
