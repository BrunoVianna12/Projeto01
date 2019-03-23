using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfessorFez.Entities;
using System.IO;
namespace ProfessorFez.Repositories
{
    public class ClienteRepositories
    {
        public void ExportarParaCsv(Cliente cliente)
        {
            using (StreamWriter writer = new StreamWriter("c:\\temp\\clientes.csv",true))
            {
                writer.WriteLine("{0};{1};{2}", cliente.IdCliente, cliente.Nome, cliente.Email);
            }

        }
    }
}
