using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaDeLivros
{
    class Control
    {
        Model modelo;
        public int opcao;
        public int opcaoL;

        public Control()
        {
            this.modelo = new Model();
            ConsultarOpcao = -1;
            ConsultarLivro = -1;
        }//fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//Fim get set

        public int ConsultarLivro
        {
            get { return this.opcaoL; }
            set { this.opcaoL = value; }
        }//Fim get set

        public void Menu()
        {
            Console.WriteLine("\nBem Vindo à nossa loja de livros! \n\n" +
                              "Escolha uma das opções abaixo: \n"      + 
                              "0. Sair.\n"                               +                                         
                              "1. Cadastro.\n"                           +
                              "2. Login.\n"                              );
            opcao = Convert.ToInt32( Console.ReadLine() );
        }//Fim do Menu

        public void MenuLivro()
        {
            Console.WriteLine("\nBem Vindo à sessão de livros! \n\n" +
                              "Escolha qual livro deseja adquirir: \n" +
                              "0. Sair.\n" +
                              "1. Harry Potter.\n" +
                              "2. Boku no Piko.\n");
            opcaoL = Convert.ToInt32(Console.ReadLine());
        }//Fim do Menu

        public void Operacao()
        {
            do
            {
                Menu();
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        this.modelo.Registrar();
                        break;
                    case 2:
                        this.modelo.ValidacaoLogin();
                            switch (ConsultarLivro)
                            {
                                MenuLivro();
                                case 0:
                                    Console.WriteLine("Obrigado! Volte sempre!");
                                    break;
                                case 1:
                                    
                            }
                        break;
                    default:
                        Console.WriteLine("Informe um valor válido!");
                        break;
                }//Fim do switch case
            } while (ConsultarOpcao != 0);
        }

    }
}
