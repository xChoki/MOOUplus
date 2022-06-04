using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pintermedio.Modelo
{
    public class CursosMoodle
    {
        int id;
        string namecourse;
        string idrol;

        public CursosMoodle() { }
        public int Id { get => id; set => id = value; }
        public string Namecourse { get => namecourse; set => namecourse = value; }
        public string Idrol { get => idrol; set => idrol = value; }
    }
}
