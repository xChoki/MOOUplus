using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class DatosNotas
    {
        int codalu;
        string codcurso;
        int idseccion;
        string nombrecurso;
        int codcarr;
        int rutprofesor;
        int periodo;
        int anno;
        float nota;
        string estatus;
        int ocasion;

        public DatosNotas() { }

        public int Codalu { get => codalu; set => codalu = value; }
        public string Codcurso { get => codcurso; set => codcurso = value; }
        public int Idseccion { get => idseccion; set => idseccion = value; }
        public string Nombrecurso { get => nombrecurso; set => nombrecurso = value; }
        public int Codcarr { get => codcarr; set => codcarr = value; }
        public int Rutprofesor { get => rutprofesor; set => rutprofesor = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Anno { get => anno; set => anno = value; }
        public float Nota { get => nota; set => nota = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public int Ocasion { get => ocasion; set => ocasion = value; }
    }
}
