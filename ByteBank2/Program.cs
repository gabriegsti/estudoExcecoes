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
                ContaCorrente conta = new ContaCorrente(514, 3333);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                
            }
            catch(ArgumentException ex)
            {
                if(ex.ParamName == "numero")
                {
                    Console.WriteLine("Argumento com problema: " + ex.ParamName);
                    
                }
                Console.WriteLine("Excecao do tipo ArgumentException");
                Console.WriteLine(ex.Message);

            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.ReadLine();
        }
    }
}
