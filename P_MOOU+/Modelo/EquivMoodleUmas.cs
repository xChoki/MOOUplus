using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_MOOU_.Modelo
{
    public class EquivMoodleUmas
    {
        int idcourse;

        public EquivMoodleUmas() { }
        public int Idcourse { get => idcourse; set => idcourse = value; }
    }
}
