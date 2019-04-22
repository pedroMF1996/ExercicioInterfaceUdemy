namespace InterfacesExercicio.Services
{
    public interface ITaxas
    {
        double JurosMensal(double amount);
        double TaxaPorPagamento(double amount);
    }
}