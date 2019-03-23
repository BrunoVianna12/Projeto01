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

        //static void Main(string[] args)
        //{
        //    //impressão no prompt de comando
        //    Console.WriteLine("\n - CADASTRO DE CLIENTE - \n");

        //    Cliente cliente = new Cliente();

        //    Console.Write("Informe o Id do Cliente......: ");
        //    cliente.IdCliente = int.Parse(Console.ReadLine());

        //    Console.Write("Informe o Nome do Cliente....: ");
        //    cliente.Nome = Console.ReadLine();

        //    Console.Write("Informe o Email do Cliente...: ");
        //    cliente.Email = Console.ReadLine();

        //    //imprimindo..
        //    Console.WriteLine("\nDados do Cliente:");
        //    Console.WriteLine("\tId do Cliente.: " + cliente.IdCliente);
        //    Console.WriteLine("\tNome..........: " + cliente.Nome);
        //    Console.WriteLine("\tEmail.........: " + cliente.Email);

        //    //instanciando a classe de repositorio
        //    ClienteRepository clienteRepository = new ClienteRepository();

        //    try //tentativa
        //    {
        //        clienteRepository.ExportarParaCsv(cliente);
        //        Console.WriteLine("\nDados gravados em CSV com sucesso!");
        //    }
        //    catch (Exception e) //captura da exceção
        //    {
        //        Console.WriteLine("Ocorreu um erro: " + e.Message);
        //    }

        //    Console.Write("\nDeseja continuar? (S)im ou (N)ão: ");
        //    string opcao = Console.ReadLine();

        //    if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
        //    {
        //        Console.Clear();

        //        //recurvidade..
        //        Main(args);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Bye!");
        //    }

        //    //pausar a execução do prompt até que
        //    //qualquer tecla seja pressionada
        //    //Console.ReadKey();
        //}

    }
}
