using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class DatosCampusMoodle
    {
        int id_campus;
        string campus;

        public DatosCampusMoodle() { }
        public int Id_campus { get => id_campus; set => id_campus = value; }
        public string Campus { get => campus; set => campus = value; }
    }
}
