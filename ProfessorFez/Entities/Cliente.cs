using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorFez.Entities
{
    public class Cliente
    {
        private int idCliente;
        private string nome;
        private string email;

        public int IdCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }

        }


    }
}
