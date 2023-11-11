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
            //Inicio cadastro
            Console.WriteLine("\n***CADASTRO***\n");
            do
            {
                //Coletando o nome
                Console.WriteLine("Informe seu nome: ");
                Cadastro[0] = Console.ReadLine();
            
                //Validando quantidade de caracteres
                if (ValidarQuantidadeCaracteres(Cadastro[0], 140))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A quantidade de caracteres é diferente do esperado.");
                }
            } while (ValidarQuantidadeCaracteres(Cadastro[0], 140) == false);

            do
            {
                //Coletando o endereço
                Console.WriteLine("Informe seu endereço: ");
                Cadastro[1] = Console.ReadLine();

                //Validando quantidade de caracteres
                if (ValidarQuantidadeCaracteres(Cadastro[1], 140))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A quantidade de caracteres é diferente do esperado.");
                }
            } while (ValidarQuantidadeCaracteres(Cadastro[1], 140) == false);

            do
            {
                //Coletando o telefone
                Console.WriteLine("Informe seu número de telefone: ");
                Cadastro[2] = Console.ReadLine();

                //Validando quantidade de caracteres
                if (ValidarQuantidadeCaracteres(Cadastro[2], 13))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A quantidade de caracteres é diferente do esperado.");
                }
            } while (ValidarQuantidadeCaracteres(Cadastro[2], 13) == false);

            do
            {
                //Coletando a data de nascimento
                Console.WriteLine("Informe a sua data de nascimento: ");
                Cadastro[3] = Console.ReadLine();

                //Validando quantidade de caracteres
                if (ValidarQuantidadeCaracteres(Cadastro[3], 8))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A quantidade de caracteres é diferente do esperado.");
                }
            } while (ValidarQuantidadeCaracteres(Cadastro[3], 8) == false);

            do
            {
                //Coletando o login de cadastro
                Console.WriteLine("Informe um nome para seu login: ");
                Cadastro[4] = Console.ReadLine();

                //Validando quantidade de caracteres
                if (ValidarQuantidadeCaracteres(Cadastro[4], 30))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A quantidade de caracteres é diferente do esperado.");
                }
            } while (ValidarQuantidadeCaracteres(Cadastro[4], 30) == false);

            do
            {
                //Coletando a senha de cadastro
                Console.WriteLine("Informe uma senha: ");
                Cadastro[5] = Console.ReadLine();

                //Validando quantidade de caracteres
                if (ValidarQuantidadeCaracteres(Cadastro[5], 12))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A quantidade de caracteres é diferente do esperado.");
                }
            } while (ValidarQuantidadeCaracteres(Cadastro[5], 12) == false);
        }//Fim do método

        public void ValidacaoLogin()
        {
            do
            {
                Console.WriteLine("\n***LOGIN***\n");
                Console.WriteLine("Digite seu login: "); //Coletando login
                login = Console.ReadLine();

                Console.WriteLine("\nDigite sua senha: "); //Coletando a senha
                senha = Console.ReadLine();
                
                //Validação
                if (login != Cadastro[4] || senha != Cadastro[5])
                {
                    Console.WriteLine("Erro! Login ou senha inválido(s).\n");
                }
            } while (login != Cadastro[4] || senha != Cadastro[5]); 
        }//Fim do método

        public void Reserva()
        {            
                //Menu de Reserva
                Console.WriteLine("Livro Indisponível!\n\n"         +
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

                        Console.WriteLine("\nEnviaremos um email para " + email + " quando o livro estiver disponível!\n");
                        break;
                    case 2:
                        break;
                }//Fim do switch
        }//Fim do método

        //Validação da quantidade de caracteres
        static bool ValidarQuantidadeCaracteres(string input, int quantidadeDesejada)
        {
            return (input.Length <= quantidadeDesejada) && (input.Length > 0);
        }

    }//Fim da classe
}//Fim do projeto 
