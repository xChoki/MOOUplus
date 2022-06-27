using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class DatosNotasMoodle
    {
        int id_student;
        float score;
        int idcourse;
        string namecourse;

        public DatosNotasMoodle() { }

        public int Id_student { get => id_student; set => id_student = value; }
        public float Score { get => score; set => score = value; }
        public int Idcourse { get => idcourse; set => idcourse = value; }
        public string Namecourse { get => namecourse; set => namecourse = value; }
    }
}
