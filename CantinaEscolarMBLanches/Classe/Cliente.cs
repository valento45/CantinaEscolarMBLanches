using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaEscolarMBLanches.Classe
{
    class Cliente
    {
        int iDCliente;

        public int IDCliente
        {
            get { return iDCliente; }
            set { iDCliente = value; }
        }
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        string tipoCliente;

        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }
        int idCurso;

        public int IDCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }
        string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        string observacoes;

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
    }
}
