using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaEscolarMBLanches.Classe
{
    class Usuario
    {
        int iDUsuario;

        public int IDUsuario
        {
            get { return iDUsuario; }
            set { iDUsuario = value; }
        }
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string usuario;

        public string Usuario1
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        Boolean perfil;

        public Boolean Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        Boolean situacao;

        public Boolean Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
