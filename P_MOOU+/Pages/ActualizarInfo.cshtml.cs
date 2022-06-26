using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P_MOOU_.Controlador;
using P_MOOU_.Modelo;

namespace P_MOOU_.Pages
{
    public class ActualizarInfoModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPostFuncionAlumnos()
        {
            Servicios servicio = new Servicios();
            List<DatosMoodle> lista;
            lista = servicio.ListarMySql(-1);

            foreach (var c in lista) {
                servicio.Insert_Alumnos(c);
            }
            ViewData["Message"] = "Insertado alumnos exitosamente";
        }
        public void OnPostFuncionCarrera()
        {
            Servicios servicio = new Servicios();
            List<DatosCarrerasMoodle> lista;
            lista = servicio.ListarCarrerasMySql("");

            foreach (var c in lista)
            {
                servicio.Insert_Carreras(c);
            }
            ViewData["Message"] = "Insertado Carreras exitosamente";
        }
        public void OnPostFuncionCampus()
        {
            Servicios servicio = new Servicios();
            List<DatosCampusMoodle> lista;
            lista = servicio.ListarCampusMySql(-1);

            foreach (var c in lista)
            {
                servicio.Insert_Campus(c);
            }
            ViewData["Message"] = "Insertado Campus exitosamente";
        }
        public void OnPostFuncionProfesores()
        {
            Servicios servicio = new Servicios();
            List<DatosProfesoresMoodle> lista;
            lista = servicio.ListarProfesoresMySql(-1);

            foreach (var p in lista)
            {
                servicio.Insert_Profesores(p);
            }
            ViewData["Message"] = "Insertado Profesores exitosamente";
        }
        public void OnPostFuncionNotas()
        {
            Servicios servicio = new Servicios();
            List<DatosNotas> lista;
            lista = servicio.ListarNotas();

            foreach (var c in lista)
            {
                servicio.P_InsertNotas(c);
                //servicio.Procedure_NotasDist(c);
                //servicio.Procedure_NotasVacio(c);
            }
            ViewData["Message"] = "Insertado Notas exitosamente";
        }

    }
}
