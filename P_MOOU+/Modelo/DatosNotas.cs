﻿using System;
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
        float nota;

        public DatosNotas() { }

        public int Codalu { get => codalu; set => codalu = value; }
        public string Idrol { get => idrol; set => idrol = value; }
        public int Codcarr { get => codcarr; set => codcarr = value; }
        public float Nota { get => nota; set => nota = value; }
    }
}
