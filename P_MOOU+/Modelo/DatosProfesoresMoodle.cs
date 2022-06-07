using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class DatosProfesoresMoodle
    {
        int id_teacher;
        string nameteacher;

        public DatosProfesoresMoodle() { }

        public int Id_teacher { get => id_teacher; set => id_teacher = value; }
        public string Nameteacher { get => nameteacher; set => nameteacher = value; }
    }
}
