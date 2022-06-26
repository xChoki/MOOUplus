using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class DatosCarrerasMoodle
    {
        string idrol;
        string namecourse;
        int idcourse;

        public DatosCarrerasMoodle() { }

        public string Idrol { get => idrol; set => idrol = value; }
        public string Namecourse { get => namecourse; set => namecourse = value; }
        public int Idcourse { get => idcourse; set => idcourse = value; }
    }
}
