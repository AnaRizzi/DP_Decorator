namespace Decorator
{
    public class Iss : Imposto
    {
        //precisa criar o construtor aqui para passar o outroImposto para o pai
        public Iss(Imposto outroImposto) : base(outroImposto) { }
        //e um construtor vazio para o caso de não haver outro imposto
        public Iss() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
