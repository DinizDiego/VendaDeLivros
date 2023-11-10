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
        private int opcao;
        public string email;
        

        public Model()
        {
            Cadastro = new string[6];
            i = 0;
            login = string.Empty;
            senha = string.Empty;
            getOpcao = -1;
        }//Fim do construtor

        public int getOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//Fim do getSet

        public void Registrar()
        {
            Console.WriteLine("\n***CADASTRO***\n");
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
                Console.WriteLine("\n***LOGIN***\n");
                Console.WriteLine("Digite seu login: ");
                login = Console.ReadLine();

                Console.WriteLine("\nDigite sua senha: "); 
                senha = Console.ReadLine();
                if (login != Cadastro[4] || senha != Cadastro[5])
                {
                    Console.WriteLine("Erro! Login ou senha inválido(s).\n");
                }
            } while (login != Cadastro[4] || senha != Cadastro[5]); 
        }//Fim do método

        public void Reserva()
        {            
                Console.WriteLine("Livro Indisponível!\n"         +
                                  "Deseja Realizar a reserva?\n"  +                    
                                  "1. Sim.\n"                     +
                                  "2. Não.\n"                       
                                                                  );
                getOpcao = Convert.ToInt32( Console.ReadLine() );

                switch (getOpcao)
                {
                    case 1:
                        Console.WriteLine("Digite seu email para contato: ");
                        email = Console.ReadLine();

                        Console.WriteLine("Enviaremos um email para " + email + " quando o livro estiver disponível!\n");
                        break;
                    case 2:
                        break;
                }//Fim do switch
        }//Fim do método

    }//Fim da classe
}//Fim do projeto 
