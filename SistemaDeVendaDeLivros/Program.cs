﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaDeLivros
{
    class Program
    {
        static void Main(string[] args)
        {
            Control controle = new Control();
            controle.Operacao();

            Console.ReadLine();//Manter o prompt aberto
        }
    }
}
