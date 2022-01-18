namespace Decorator
{
    public class Icms : Imposto
    {
        //precisa criar o construtor aqui para passar o outroImposto para o pai
        public Icms(Imposto outroImposto) : base(outroImposto) { }
        //e um construtor vazio para o caso de não haver outro imposto
        public Icms() : base() { }

        //precisa de um onstrutor vazio para 

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
