using System;
using System.Collections.Generic;
using InterfacesExercicio.Services;

namespace InterfacesExercicio.Entities
{
    public class Contrato
    {
        public int NumeroDoContrato { get; set; }
        public DateTime DataDoContrato { get; set; }
        public double ValorTotalDoContrato { get; set; }

        

        public Contrato(int numeroDoContrato, DateTime dataDoContrato, double valorTotalDoContrato)
        {
            NumeroDoContrato = numeroDoContrato;
            DataDoContrato = dataDoContrato;
            ValorTotalDoContrato = valorTotalDoContrato;
        }

        
        

        
    }
}