namespace Decorator
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

    }
}