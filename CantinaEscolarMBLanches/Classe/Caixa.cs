using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaEscolarMBLanches.Classe
{
    class Caixa
    {
        int idCaixa;

        public int IdCaixa
        {
            get { return idCaixa; }
            set { idCaixa = value; }
        }
        int idUsuario;

        public int IDUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        Boolean tipo;

        public Boolean Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        //SQL - C#
        /*
         * int - int
         * varchar, char, text - string
         * date, time, datetime - datetime
         * bit - bool
         * decimal, money - double
         */ 


    }
}
