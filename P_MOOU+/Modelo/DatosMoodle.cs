using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pintermedio.Modelo
{
    public class DatosMoodle
    {
		int id_table;
		int idcourse;
		int id_student;
		string lastname1;
		string lastname2;
		string firstname;
		string idrol;
		int idsection;
		string namecourse;
		float score;
		int attendance;
		int id_teacher;
		string nameteacher;
		int id_campus;
		string tipe_schedule;


		public DatosMoodle() { }

        public int Id_table { get => id_table; set => id_table = value; }
        public int Idcourse { get => idcourse; set => idcourse = value; }
        public int Id_student { get => id_student; set => id_student = value; }
        public string Lastname1 { get => lastname1; set => lastname1 = value; }
        public string Lastname2 { get => lastname2; set => lastname2 = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Idrol { get => idrol; set => idrol = value; }
        public int Idsection { get => idsection; set => idsection = value; }
        public string Namecourse { get => namecourse; set => namecourse = value; }
        public float Score { get => score; set => score = value; }
        public int Attendance { get => attendance; set => attendance = value; }
        public int Id_teacher { get => id_teacher; set => id_teacher = value; }
        public string Nameteacher { get => nameteacher; set => nameteacher = value; }
        public int Id_campus { get => id_campus; set => id_campus = value; }
        public string Tipe_schedule { get => tipe_schedule; set => tipe_schedule = value; }
    }
}
