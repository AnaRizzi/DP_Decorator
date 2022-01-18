namespace Decorator
{
    public abstract class Imposto
    {
        public abstract double Calcula(Orcamento orcamento);

        //Para que um imposto possa receber outro para calcular vários juntos,
        //é necessário alterar esta interface para classe abstrata e receber o outro imposto
        public Imposto OutroImposto { get; set; }

        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        //precisa de um construtor vazio para quando não houver próximo imposto
        protected Imposto()
        {
            OutroImposto = null;
        }

        //o método calcula já espera um outro imposto e chama o método Calcula dele automaticamente
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}