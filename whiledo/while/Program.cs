using System;

class porcentag
{
    
       public static void Main(string[] args)

        {

        double dinheiro;
        double taxajuros, taxainvestimento, resultadoinvestimento;
        int mes, contagem = 1;

        Console.WriteLine("quanto voce pretende investir");
        dinheiro = double.Parse(Console.ReadLine());

        Console.WriteLine("qual a taxa de juros que você deseja aplicar ? (nao use %)");
        taxajuros = double.Parse(Console.ReadLine());
        taxainvestimento = taxajuros / 100;

        Console.WriteLine("em quantos meses você deseja receber o dinheiro ?");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("");
           while  (contagem <= mes)
            {
            dinheiro = dinheiro + (dinheiro * taxainvestimento);
            Console.WriteLine("o valor do" + contagem + "ª mês investido foi de :"+dinheiro);
            contagem = contagem + 1;
                
            }


        
        }
    
}
