using System;
using System.Collections.Generic;
using InterfacesExercicio.Entities;

namespace InterfacesExercicio.Services
{
    public class ProcessarRegistro
    {
        
        public List<Registro> Registros = new List<Registro>();
        public Contrato Contrato { get; private set; }
        private ITaxas _taxas;

        public ProcessarRegistro(ITaxas taxas, Contrato contrato)
        {
            _taxas = taxas;
            Contrato = contrato;
        }


        public void RegistrandoParcelaPorMes(int qteMes)
        {
            double valorParcela = 0.00;
            DateTime dataParcela;
            for (int i = 0; i < qteMes; i++)
            {
                valorParcela = (Contrato.ValorTotalDoContrato/qteMes) + _taxas.JurosMensal(Contrato.ValorTotalDoContrato / qteMes) * (i + 1);
                valorParcela += _taxas.TaxaPorPagamento(valorParcela);
                dataParcela  = Contrato.DataDoContrato.AddMonths(i + 1);
                Registros.Add(new Registro(dataParcela, valorParcela));
            }
        }
        
        public override string ToString()
        {
            string registros = "Installments: \n";
            foreach (Registro registro in Registros)
            {
                registros += $"\n{registro}";
            }

            return registros;
        }
    }
}