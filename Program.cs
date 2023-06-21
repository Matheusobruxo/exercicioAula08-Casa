using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula08_Casa
{
    internal class Program
    {
        public static List<string> usuarios = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de usuários");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Buscar");
            Console.WriteLine("3 - Deletar");
            Console.WriteLine("4 - Alterar");
            Console.WriteLine("5 - Listar usuários");
            int opcao = int.Parse(Console.ReadLine());


            if (opcao == 2 || opcao == 3 || opcao == 4 || opcao == 5)
            {
                if (usuarios.Count < 0)
                {
                    Console.WriteLine("\nAinda não há usuários cadastrados");
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);
                    return;
                }
            }
            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do usuário que gostaria de cadastrar!");
                string adicionado = Console.ReadLine();
                usuarios.Add(adicionado);

                Console.WriteLine($"O usuário {adicionado} foi cadastado com sucesso! !");
            }
            if (opcao == 2)
            {
                Console.WriteLine("Digite o usuário que deseja buscar!");
                string busca = Console.ReadLine();

                if (usuarios.Contains(busca))
                {
                    Console.WriteLine($"O usuário {busca} foi localizado na posição {usuarios.IndexOf(busca)} !");
                }
                else
                {
                    Console.WriteLine("Usuário não cadastrado");
                }
            }
            if (opcao == 3)
            {
                Console.WriteLine("Digite o numero do usuário que deseja deletar!");
                int delete = int.Parse(Console.ReadLine());
                string deletado = usuarios[delete];


                if (delete > usuarios.Count)
                {
                    Console.WriteLine("Usuário não encontrado");
                    Main(null);
                    return;
                }

                Console.WriteLine($"O usuário {deletado} foi deletado com sucesso!");
                usuarios.Remove(deletado);

            }
            if (opcao == 4)
            {
                Console.WriteLine("Digite o nome do usuário que deseja alterar!");
                string alterar = Console.ReadLine();
                int alterado = usuarios.IndexOf(alterar);


                if (usuarios.Contains(alterar))
                {

                    Console.WriteLine($"O usuário {alterar} foi encontrado com sucesso !");
                    Console.WriteLine("Digite o novo usuário que ocupará essa posição:");
                    string newUser = Console.ReadLine();

                    Console.WriteLine($"O usuário {alterar} será substituido por {newUser}!");
                    usuarios[alterado] = newUser;

                }


            }
            if (opcao == 5)
            {
                int contador = 0;
                while (contador < usuarios.Count)
                {
                    string nomeUser = usuarios[contador];
                    Console.WriteLine($"{contador} - {nomeUser}");
                    contador++;
                }

                Console.ReadKey();
            }


            Console.ReadKey();
            Console.Clear();
            Main(null);
            return;
        }


    }


}


