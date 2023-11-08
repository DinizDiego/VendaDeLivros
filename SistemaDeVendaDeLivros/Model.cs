using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaDeLivros
{
    class Model
    {
        public string[] Cadastro;
        public int i;
        public string login;
        public string senha;

        public Model()
        {
            Cadastro = new string[6];
            i = 0;
            login = string.Empty;
            senha = string.Empty;
        }//Fim do construtor

        public void Registrar()
        {
            Console.WriteLine("Informe seu nome: ");
            Cadastro[0] = Console.ReadLine();

            Console.WriteLine("Informe seu endereço: ");
            Cadastro[1] = Console.ReadLine();

            Console.WriteLine("Informe seu número de telefone: ");
            Cadastro[2] = Console.ReadLine();

            Console.WriteLine("Informe a sua data de nascimento: ");
            Cadastro[3] = Console.ReadLine();

            Console.WriteLine("Informe um nome para seu login: ");
            Cadastro[4] = Console.ReadLine();

            Console.WriteLine("Informe uma senha: ");
            Cadastro[5] = Console.ReadLine();
        }//Fim do método

        public void ValidacaoLogin()
        {
            do
            {
                Console.WriteLine("Informe seu login: ");
                login = Console.ReadLine();

                Console.WriteLine("Informe sua senha: "); 
                senha = Console.ReadLine();
                if (login != Cadastro[4] || senha != Cadastro[5])
                {
                    Console.WriteLine("Erro! Login ou senha inválido(s).");
                }
            } while (login != Cadastro[4] || senha != Cadastro[5]); 
        }//Fim do método


    }
}
