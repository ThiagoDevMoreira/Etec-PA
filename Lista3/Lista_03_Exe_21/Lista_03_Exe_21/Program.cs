﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_03_Exe_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double vt, pe=0, aux;
            int cp, i=0;
            string re;
            do {
                Console.Write("Digite o valor do {0}º produto: ", i+1);
                aux = double.Parse(Console.ReadLine());
                pe += aux;
                i++;
                do
                {
                    Console.Write("Deseja adicionar outro produto?(S/N): ");
                    re = Console.ReadLine().ToLower();
                    
                } while (re != "s" && re != "n");
                
            } while (re == "s");
            Console.WriteLine();
            Console.WriteLine("Digite o modo de pagamento(1, 2, 3 ou 4)");
            Console.WriteLine("1. À vista em dinheiro ou cheque, com 10% de desconto");
            Console.WriteLine("2. À vista com cartão de crédito, com 5% de desconto");
            Console.WriteLine("3. Em 2 vezes, preço normal de etiqueta sem juros");
            Console.WriteLine("4. Em 3 vezes, preço de etiqueta com acréscimo de 10%");
            cp = int.Parse(Console.ReadLine());
            switch (cp)
            {
                case 1:
                    vt = pe - pe * 0.1;
                    Console.WriteLine("Deve ser pago: {0:C}", vt);
                    break;
                case 2:
                    vt = pe - pe * 0.05;
                    Console.WriteLine("Deve ser pago: {0:C}", vt);
                    break;
                case 3:
                    vt = pe / 2;
                    Console.WriteLine("Deve ser pago em 2 vezes de: {0:C}", vt);
                    break;
                case 4:
                    vt = (pe + pe * 0.1) / 3;
                    Console.WriteLine("Deve ser pago em 3 vezes de: {0:C}", vt);
                    break;
                default:
                    Console.WriteLine("Comando desconhecido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
