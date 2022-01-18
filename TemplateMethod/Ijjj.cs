namespace Decorator
{
    public class Ijjj : TemplateDeImpostoCondicional
    {
        //o método de Imposto já foi implementado no Template, então só complementa com as informações que faltam

        //precisa criar o construtor aqui para passar o outroImposto para o pai
        public Ijjj(Imposto outroImposto) : base(outroImposto) { }
        //e um construtor vazio para o caso de não haver outro imposto
        public Ijjj() : base() { }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach(var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
