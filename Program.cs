using System;
using System.Collections.Generic;
using Poo.models;

namespace Poo
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static List<Banco> contasBanco = new List<Banco>();
        static int countID = 1;

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("\n=== Sistema de Cadastro ===");
                Console.WriteLine("1 - Cadastrar Usuário");
                Console.WriteLine("2 - Listar Usuários");
                Console.WriteLine("3 - Cadastrar Conta Bancária");
                Console.WriteLine("4 - Listar Contas Bancárias");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        usuarios.Add(Usuario.CadastrarUser());
                        break;
                    case 2:
                        Usuario.ListarUser(usuarios);
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Banco conta = Banco.CadastrarConta(usuarios, countID++);
                        contasBanco.Add(conta);
                        break;
                    case 4:
                        Banco.ListarConta(contasBanco);
                        Thread.Sleep(2000);
                        break;
                    case 0:
                        Console.WriteLine("Encerranco o Sistema...");
                        break;
                }

            } while (opcao != 0);
        }
    }
}