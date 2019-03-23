using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using System.IO;

namespace Projeto01.Repositories
{
    public class ClienteRepositories
    {
        public void ExportarParaCSV(List<Cliente> clientes)
        {
            using (StreamWriter writer = new StreamWriter("c:\\temp\\clientes.csv"))
            {
                writer.WriteLine($"{clientes.First().Id.GetType()};{clientes.Select(x => x.Nome.GetType())}; {clientes.Select(x => x.Email.GetType())}");
                foreach (var cliente in clientes)
                {
                    writer.WriteLine($"{cliente.Id};{cliente.Nome};{cliente.Email}");
                }
                
                
            }

        }
    }
}
