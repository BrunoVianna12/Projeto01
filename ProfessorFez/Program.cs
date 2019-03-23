using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfessorFez.Entities;
using ProfessorFez.Repositories;
namespace ProfessorFez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n- Cadastro do cliente - \n");
            Cliente cliente = new Cliente();
            Console.Write("Informe o id Do cliente ");
            cliente.IdCliente = int.Parse(Console.ReadLine());
            Console.Write("Informe o Nome ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Informe o email do cliente ");
            cliente.Email = Console.ReadLine();

            //Imprimindo
            Console.WriteLine("\nDados do cliente:");
            Console.WriteLine("\tId do cliente.: " + cliente.IdCliente);
            Console.WriteLine("\tNome..........: " + cliente.Nome);
            Console.WriteLine("\tEmail.........: " + cliente.Email);

            ClienteRepositories clienteRepositories = new ClienteRepositories();

            try
            {
                clienteRepositories.ExportarParaCsv(cliente);
                Console.WriteLine("\nDados gravados com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu merda " + e.Message);
                
            }
            Console.WriteLine("Deseja Continuar? (S)im ou (N)ão: ");
            string opcao = Console.ReadLine();

            if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("BYE");
            }
            Console.ReadKey();
        }
    }
}
