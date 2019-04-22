using System;
using System.Globalization;

namespace InterfacesExercicio.Entities
{
    public class Registro
    {
        public DateTime dataParcela { get; set; }
        public double valorParcela { get; set; }

        public Registro(DateTime dataParcela, double valorParcela)
        {
            this.dataParcela = dataParcela;
            this.valorParcela = valorParcela;
        }

        public override string ToString()
        {
            return $"{dataParcela.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)} - {valorParcela.ToString("f2",CultureInfo.InvariantCulture)}";
        }
    }
}