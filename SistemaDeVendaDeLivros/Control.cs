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
        private int opcao;
        private int opcaoL;
        public int Carrinho;
        public int i;

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
            Console.WriteLine("\n***Bem Vindo à nossa loja de livros!*** \n\n" +
                              "É sua primeira vez aqui? \n"                    + 
                              "0. Sair.\n"                                     +                                         
                              "1. Sim.\n"                                      +
                              "2. Não.\n"                                      );
            opcao = Convert.ToInt32( Console.ReadLine() );
        }//Fim do Menu

        public void MenuLivro()
        {
            Console.WriteLine("\n***Bem Vindo à sessão de livros!*** \n\n"   +
                              "Escolha o que deseja fazer: \n"               +
                              "0. Sair.\n"                                   +
                              "1. Adquirir Harry Potter. R$60,00\n"          +
                              "2. Adquirir Boku no Piko. SEM ESTOQUE!\n"     +
                              "3. Adquirir Senhor do Anéis. SEM ESTOQUE!\n"  +
                              "4. Adquirir Turma da Mônica. R$10,00\n"       +
                              "5. Adquirir God of War. R$100,00\n"           +
                              "6. Adquirir A Arte da Guerra. R$45,00\n"      +
                              "7. Valor Total\n"                             +
                              "8. Efetuar o pagamento.\n" 
                                                                             );
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
                        this.modelo.ValidacaoLogin();
                        do
                        {
                            MenuLivro();
                            switch (ConsultarLivro)
                            {
                                case 0:
                                    Console.WriteLine("Obrigado! Volte sempre!");
                                    break;
                                case 1:
                                    Console.WriteLine("Você adcionou o livro Harry Potter ao seu carrinho!");
                                    Carrinho += 60;
                                    break;
                                case 2:
                                    this.modelo.Reserva();
                                    break;
                                case 3:
                                    this.modelo.Reserva();
                                    break;
                                case 4:
                                    Console.WriteLine("Você adcionou o livro Turma da Mônica ao seu carrinho!");
                                    Carrinho += 10;
                                    break;
                                case 5:
                                    Console.WriteLine("Você adcionou o livro God of War ao seu carrinho!");
                                    Carrinho += 100;
                                    break;
                                case 6:
                                    Console.WriteLine("Você adcionou o livro A Arte da Guerra ao seu carrinho!");
                                    Carrinho += 45;
                                    break;
                                case 7:
                                    Console.WriteLine("O valor total da sua compra é: R$" + Carrinho);
                                    break;
                                case 8:
                                    Console.WriteLine("\n***Prossiga para o pagamento***\n"                   +
                                                      "\nInsira abaixo as informações do cartão de crédito: " +
                                                      "\nNúmero do cartão: ____-____-____-____ "              +
                                                      "\nNome no cartão: "                                    +
                                                      "\nValidade__/__"                                       +
                                                      "\nCVV:___");
                                    break;
                                default:
                                    Console.WriteLine("Erro! Escolha uma opção válida.");
                                    break;
                            }//Fim do switch
                        } while (opcaoL != 0 && opcaoL != 8);
                        break;                        
                    case 2:
                        this.modelo.ValidacaoLogin();

                        do
                        {
                            MenuLivro();
                            switch (ConsultarLivro)
                            {
                                case 0:
                                    Console.WriteLine("Obrigado! Volte sempre!");
                                    break;
                                case 1:
                                    Console.WriteLine("Você adcionou o livro Harry Potter ao seu carrinho!");
                                    Carrinho += 60;
                                    break;
                                case 2:                                   
                                    this.modelo.Reserva();
                                    break;
                                case 3:
                                    this.modelo.Reserva();
                                    break;
                                case 4:
                                    Console.WriteLine("Você adcionou o livro Turma da Mônica ao seu carrinho!");
                                    Carrinho += 10;
                                    break;
                                case 5:
                                    Console.WriteLine("Você adcionou o livro God of War ao seu carrinho!");
                                    Carrinho += 100;
                                    break;
                                case 6:
                                    Console.WriteLine("Você adcionou o livro A Arte da Guerra ao seu carrinho!");
                                    Carrinho += 45;
                                    break;
                                case 7:
                                    Console.WriteLine("O valor total da sua compra é: R$" + Carrinho);
                                    break;
                                case 8:
                                    Console.WriteLine("\n***Prossiga para o pagamento***."                    +
                                                      "\nInsira abaixo as informações do cartão de crédito: " +
                                                      "\nNúmero do cartão: ____-____-____-____ "              +
                                                      "\nNome no cartão: "                                    +
                                                      "\nValidade__/__"                                       +
                                                      "\nCVV:___");
                                    break;
                                default:
                                    Console.WriteLine("Erro! Escolha uma opção válida.");
                                    break;
                            }//Fim do switch
                        } while (opcaoL != 0 && opcaoL != 8);
                        break;
                    default:
                        Console.WriteLine("Erro! Escolha uma opção válida.");
                        break;                        
                }//Fim do switch case
            } while (ConsultarOpcao != 0);
        }//Fim do DoWhile
    }//Fim do método
}//Fim do projeto
