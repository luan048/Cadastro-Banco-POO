using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.models
{
    public class Banco
    {
        public int IdConta { get; set; }
        public Usuario InfoUsuario { get; set; }
        public DateTime DataCriacao { get; set; }

        public void ExibirConta()
        {
            Console.WriteLine($"Conta ID: {IdConta}");
            InfoUsuario.ExibirInfo();
            Console.WriteLine($"Data de criação: {DataCriacao.ToShortDateString()}");
        }

        public static Banco CadastrarConta(List<Usuario> usuarios, int idConta)
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário foi cadastrado.");
                return null;
            }

            Console.WriteLine("\n=== Cadastro de Conta ===");
            Console.WriteLine("Escolha o usuário pelo número:");

            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.Write($"{i + 1} - ");
                usuarios[i].ExibirInfo();
            }

            Console.Write("Número do usuário: ");
            int escolhaUser = int.Parse(Console.ReadLine());

            if (escolhaUser < 1 || escolhaUser > usuarios.Count)
            {
                Console.WriteLine("Escolha inválida.");
                return null;
            }

            Banco conta = new Banco
            {
                IdConta = idConta,
                InfoUsuario = usuarios[escolhaUser - 1],
                DataCriacao = DateTime.Now
            };

            Console.WriteLine("Conta bancária criada com sucesso!");
            return conta;
        }

        public static void ListarConta(List<Banco> contas)
        {
            Console.WriteLine("\n=== Lista de Contas Bancárias ===");

            if (contas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta criada");
                return;
            }

            foreach (var conta in contas)
            {
                conta.ExibirConta();
                Console.WriteLine("---------------------");
            }
        }
    }
}