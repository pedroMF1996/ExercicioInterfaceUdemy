using System;
using System.Globalization;
using InterfacesExercicio.Entities;
using InterfacesExercicio.Services;

namespace InterfacesExercicio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * processamento de contrato
             * gerar as parcelas a serem pagas por aquele contrato com base no numero de meses desejado
             * servico de pagamento online:
             *     juro mensal: 0.01 a cada parcela
             *     taxa por pagamento: 0.02
             *
             * [ok]ler os dados de um contrato
             * [ok]numero do contrato(ok)
             * [ok]data do contrato(ok)
             * [ok]valor total do contrato(ok)
             *
             * []ler o numero de meses para o parcelamento do contrato
             *
             * []Gerar os registros de parcelas a serem pagas
             * []cada registro tera data e valor
             * "sendo a primeira parcela a ser paga um mês após a data do contrato,
             *  a segunda parcela dois meses após o contrato e assim por diante"
             *
             * []Mostrar os dados das parcelas na tela    
             */

            try
            {
                Console.WriteLine("Enter contract data: ");
                Console.Write("Number: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime data = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double valor = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Contrato contrato = new Contrato(numero,data,valor); 
            
                Console.Write("Enter number of installments: ");
                int qteMes = int.Parse(Console.ReadLine());
            
                ProcessarRegistro processarRegistro = new ProcessarRegistro(new TaxasPaypal(), contrato);
            
                processarRegistro.RegistrandoParcelaPorMes(qteMes);

                Console.WriteLine(processarRegistro);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            

        }
    }
}