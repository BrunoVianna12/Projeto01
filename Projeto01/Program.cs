using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Repositories;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            Console.WriteLine("---------------------Seja bem vindo ao .NET---------------------");
            Console.WriteLine("\nInforme quantos clientes quer cadastrar");
            int numeroDePessoas = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeroDePessoas; i++)
            {
                Cliente cliente = new Cliente();
                Console.WriteLine("Entre com os dados do Cliente abaixo");
                Console.WriteLine("Digite o Nome do Cliente");
                cliente.Id = i+1;
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Informe o email do cliente");
                cliente.Email = Console.ReadLine();

                clientes.Add(cliente);
                

            }

            ClienteRepositories clienteRepositories = new ClienteRepositories();

            try
            {
                clienteRepositories.ExportarParaCSV(clientes);
                Console.WriteLine("Exportado com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu merda: " + e.Message);

            }




            Console.ReadKey();
        }
    }
}
