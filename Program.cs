using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("stella");
            nomes.Add("william");
            nomes.Add("luis");
            nomes.Add("luis");
            nomes.Add("luis");
            nomes.Add("luis");
            nomes.Add("luis");
            nomes.Add("luis");
            nomes.Add("luis");
            nomes.Add("luis");
            int cont = 0;
            while (cont < nomes.Count) 
            {
                Console.WriteLine($"o nome é {nomes[cont]} ");
                cont++;
            }


            Console.ReadKey();
        }
        void atividadeTerminar()
        {
            //static List<string> nomes = new List<string>(); é para ser usado fora do main 
            /* int opcao;
             nomes.Add("");
             int busca;

             Console.WriteLine("Cadastro de usuarios!");
             Console.WriteLine("1 - Cadastrar");
             Console.WriteLine("2 - Buscar");
             opcao = Int32.Parse(Console.ReadLine());

             if (opcao == 1)
             {
                 Console.WriteLine("digite o nome que deseja cadastrar:");
                 nomes[0] = (Console.ReadLine());
                 Console.WriteLine("Cadastro feito com sucesso");
                 Main(null);
             }
             Console.WriteLine("digite a posição que quer buscar:");
             busca = Int32.Parse(Console.ReadLine());
             int quant = nomes.Count;
             if (quant == busca)
             {
                 Console.WriteLine($"{nomes}");
             }







             Console.ReadKey();
            */
        }
        void array()
        {
            string[] nomes = new string[3];
            //int[] idades = { 19, 20, 74, 55, 11, };
            //int[] idades = new int[6];
            Console.WriteLine("digite um valor para nome 0 ");


            nomes[0] = "";
            nomes[2] = "Leonardo";
            nomes[1] = "Konichi";

            nomes[0] = (Console.ReadLine());
            Console.WriteLine($"o nome da primeira posição é {nomes[0]}");
            Console.WriteLine($"o nome da segunda posição é {nomes[1]}");
            Console.WriteLine($"o nome da terçeira posição é {nomes[2]}");



            Console.ReadKey();
        }
        void teorico()
        {
            List<string> nomes = new List<string>();
            nomes.Add("conrado");
            nomes.Add("leonardo");
            nomes.Add("eduardo");



            Console.WriteLine($"a primeira posiçao é {nomes[0]}");
            Console.WriteLine($"a primeira posiçao é {nomes[1]}");
            Console.WriteLine($"a primeira posiçao é {nomes[2]}");
            nomes.RemoveAt(1);
            //nomes.Remove("leonardo");
            int quant = nomes.Count;
            //nomes.count tambem funciona
            Console.WriteLine($"existe {quant} de itens da minha lista");

            Console.ReadKey();

            /*int contador = 0;
            while (1000 > contador)
            {
                Console.WriteLine("ola");
                contador = contador + 1;//(contador +=1;) repete o valor que tinha +1
                //para acumular valores em uma variavel
            }
            */

        }
        
    }  
}        

