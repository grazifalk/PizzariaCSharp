using PizzariaCSharp.Enums;

namespace PizzariaCSharp.Model
{
    public class Pizza
    {
        public int Id {get;set;}
        public ETipoPizza TipoPizza {get;set;}
        public ETipoBorda TipoBorda {get; set;}
        public List<Sabor> Sabores {get; set;}
        public double Valor {get;set;}

        public Pizza(
            ETipoPizza tipoPizza, 
            ETipoBorda tipoBorda, 
            double valor, 
            List<Sabor> sabores)
        {
            TipoPizza = tipoPizza;
            TipoBorda = tipoBorda;
            Valor = valor;
            Sabores = sabores;
        }
    }
}