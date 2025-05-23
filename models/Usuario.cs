using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo.models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} ; Idade {Idade}, Profissão: {Profissao}");
        }

        public static Usuario CadastrarUser()
        {
            Usuario u = new Usuario();

            Console.Write("Digite o nome do usuário que deseja cadastrar: ");
            u.Nome = Console.ReadLine();

            Console.Write("Digite a idade do usuário: ");
            u.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a profissão do usuário: ");
            u.Profissao = Console.ReadLine();

            Console.WriteLine("Usuário cadastrado com sucesso!");
            return u;
        }

        public static void ListarUser(List<Usuario> usuarios)
        {
            Console.WriteLine("\n=== Lista de usuários ===");
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário foi cadastrado");
                return;
            }

            foreach (var u in usuarios)
            {
                u.ExibirInfo();
            }
        }
    }
}