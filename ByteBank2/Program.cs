using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch no metodo main");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
        private static void CarregarContas()
        {

            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                // IDisposable
                leitor.LerProximaLinha();
            }



            // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- -----
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //    leitor.Fechar();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                //conta1.Transferir(1000, conta2);
                conta1.Sacar(1000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
