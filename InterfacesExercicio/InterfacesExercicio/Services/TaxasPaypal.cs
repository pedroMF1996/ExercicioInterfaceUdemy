namespace InterfacesExercicio.Services
{
    public class TaxasPaypal:ITaxas
    {
        public double JurosMensal(double amount)
        {
            return amount *= 0.01;
        }

        public double TaxaPorPagamento(double amount)
        {
            return amount *= 0.02;
        }
    }
}