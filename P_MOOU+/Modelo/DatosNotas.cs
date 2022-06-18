using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class DatosNotas
    {
        int codalu;
        string idrol;
        int codcarr;
        float notaM;

        public DatosNotas() { }

        public int Codalu { get => codalu; set => codalu = value; }
        public string Idrol { get => idrol; set => idrol = value; }
        public int Codcarr { get => codcarr; set => codcarr = value; }
        public float NotaM { get => notaM; set => notaM = value; }
        public float NotaU { get => notaU; set => notaU = value; }
    }
}
