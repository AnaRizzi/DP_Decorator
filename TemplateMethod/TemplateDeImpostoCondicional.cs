namespace Decorator
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        //o template vai herdar de Imposto
        //precisa criar o construtor aqui para passar o outroImposto para o pai
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }
        //e um construtor vazio para o caso de não haver outro imposto
        public TemplateDeImpostoCondicional() : base() { }

        //o método é resumido para esse modelo
        //tudo o que é informação específica vira um novo método abstrato que será implementado por cada classe
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento)){
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
