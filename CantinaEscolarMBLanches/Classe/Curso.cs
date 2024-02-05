using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaEscolarMBLanches.Classe
{
    class Curso
    {
        int Idcurso;

        public int IDCurso
        {
            get { return Idcurso; }
            set { Idcurso = value; }
        }
        string cursos;

        public string Cursos
        {
            get { return cursos; }
            set { cursos = value; }
        }
    }
}
